  PaketYemekEntities _db = new PaketYemekEntities(); //Benim veritabanı : PaketYemek

        public ActionResult Index()
        {
            var query =
              (from illers in _db.tbl_il
               orderby illers.il_ad

               select new
               {
                   il_id = illers.il_id,
                   il_ad = illers.il_ad
               }).ToList();


            List<SelectListItem> items = new List<SelectListItem>();

            foreach (var item in query)
            {
                items.Add(new SelectListItem { Text = @item.il_ad, Value = @item.il_id.ToString() });
            }


            ViewBag.IIller = new SelectList(items, "Value", "Text");

            return View();
        }

        public JsonResult IlceList(string Id)
        {
            int il_id = Convert.ToInt32(Id);
            var district = (from s in _db.tbl_ilce
                            orderby s.ilce_ad
                            where s.il_id == il_id
                            select s);

            return Json(new SelectList(district.ToArray(), "ilce_id", "ilce_ad"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult SemtList(string Id)
        {
            int ilce_id = Convert.ToInt32(Id);
            var district = (from s in _db.tbl_semt
                            orderby s.semt_ad
                            where s.ilce_id == ilce_id
                            select s);

            return Json(new SelectList(district.ToArray(), "semt_id", "semt_ad"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult MahalleList(string Id)
        {
            int semt_id = Convert.ToInt32(Id);
            var district = (from s in _db.tbl_mahalle
                            orderby s.mahalle_ad
                            where s.semt_id == semt_id
                            select s);

            return Json(new SelectList(district.ToArray(), "mahalle_id", "mahalle_ad"), JsonRequestBehavior.AllowGet);
        }
