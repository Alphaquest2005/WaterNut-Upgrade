﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentItemDS.Business.Entities;
using DocumentItemDS.Business.Services;
using System.Data.Entity;


namespace WaterNut.DataSpace
{
    public class AsycudaEntrySummaryListModel
    {
        private static readonly AsycudaEntrySummaryListModel instance;
        static AsycudaEntrySummaryListModel()
        {
            instance = new AsycudaEntrySummaryListModel();
        }

        public static AsycudaEntrySummaryListModel Instance
        {
            get { return instance; }
        }

        internal async Task RemoveSelectedItems(IEnumerable<int> lst)
        {
            try
            {
                int ASYCUDA_Id = 0;
                using (var ctx = new DocumentItemDSContext() {StartTracking = true})
                {


                    foreach (var item_id in lst)
                    {
                        var item =
                            ctx.xcuda_Item.Include(x => x.xcuda_PreviousItem).FirstOrDefault(x => x.Item_Id == item_id);
                        if (item != null)
                        {
                            if (ASYCUDA_Id == 0) ASYCUDA_Id = item.ASYCUDA_Id;
                            ctx.xcuda_Item.Remove(item);

                        }
                    }



                    ctx.SaveChanges();
                }
                await ReorderDocumentItems(ASYCUDA_Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task ReorderDocumentItems(int ASYCUDA_Id)
        {
            List<xcuda_Item> rlst;
            using (var ctx = new xcuda_ItemService())
            {
                rlst =
                    (await ctx.Getxcuda_ItemByExpression(string.Format("ASYCUDA_Id == {0}", ASYCUDA_Id),
                        new List<string>()
                        {
                            "xcuda_PreviousItem"
                        })
                        .ConfigureAwait(false))
                        .OrderBy(x => x.LineNumber)
                        .ToList();
            }

            //if (!rlst.Where(x => x.xcuda_PreviousItem != null).Select(x => x.xcuda_PreviousItem).Any()) return;

            for (int i = 0; i < rlst.Count(); i++)
            {
                rlst.ElementAt(i).LineNumber = i + 1;
                if (rlst.ElementAt(i).xcuda_PreviousItem != null)
                {
                    rlst.ElementAt(i).xcuda_PreviousItem.StartTracking();
                    rlst.ElementAt(i).xcuda_PreviousItem.Current_item_number = (i + 1).ToString();
                }
            }

            using (var ctx = new xcuda_PreviousItemService())
            {
                foreach (var p in rlst.Select(x => x.xcuda_PreviousItem))
                {
                    if (p == null) continue;
                    p.xcuda_Item = null;
                    await ctx.Updatexcuda_PreviousItem(p).ConfigureAwait(false);
                }
            }

            using (var ctx = new DocumentItemDSContext())
            {
                foreach (var i in rlst)
                {
                    ctx.Database.ExecuteSqlCommand("update xcuda_Item" +
                                                   $" set linenumber = {i.LineNumber}" +
                                                   $" where Item_Id = {i.Item_Id}");
                }
            }
        }
    }
}