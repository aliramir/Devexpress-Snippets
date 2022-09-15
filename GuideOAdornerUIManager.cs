#region Guide

        private void help_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetLesson(0);
        }

        private void adornerUIManager1_QueryGuideFlyoutControl(object sender, QueryGuideFlyoutControlEventArgs e)
        {
            e.Control = new UserControl
            {
                Width = this.Width - 50,
                Height = 120,
                Padding = new Padding(5),
                RightToLeft = RightToLeft.Yes,
            };

            var labelGuide = new LabelControl()
            {
                AllowHtmlString = true,
                Dock = DockStyle.Fill,
                AutoSizeMode = LabelAutoSizeMode.Vertical,
                Text = _msg,
            };

            var btnNextGuide = new SimpleButton
            {
                Text = @"بعدی"
            };

            var lc = new LayoutControl()
            {
                Dock = DockStyle.Fill,
                RightToLeft = RightToLeft.Yes
            };
            lc.AddItem(string.Empty, labelGuide).TextVisible = false;
            lc.AddItem(string.Empty, btnNextGuide);

            e.Control.AddControl(lc);
            btnNextGuide.Click += btnNextGuide_Click;
        }
        private void btnNextGuide_Click(object sender, EventArgs e)
        {
            _countLessons++;
            SetLesson(_countLessons);
        }

        private int _countLessons = 0;
        private string _msg;
        private void SetLesson(int index)
        {
            adornerUIManager1.ShowGuides = DevExpress.Utils.DefaultBoolean.True;
            switch (index)
            {
                case 0:
                    Guide1(); break;
                case 1:
                    Guide2(); break;
                case 2:
                    Guide3(); break;
                case 3:
                    Guide4(); break;
                default:
                    adornerUIManager1.ShowGuides = DevExpress.Utils.DefaultBoolean.False;
                    _countLessons = 0;
                    break;
            }
        }
        private void Guide1()
        {
            _msg = "شماره کمد مورد نظر را وارد کنید<br>این شماره نباید تکراری باشد";
            guide1.TargetElement = closetNumber;
        }
        private void Guide2()
        {
            _msg = "کد تگ یا مچ بند برای هر لاکر <br> هر مچ بند فقط برای یک کمد می باشد";
            guide1.TargetElement = rfidTag;
        }
        private void Guide3()
        {
            _msg = "این دکمه اطلاعات کمد را ذخیره می کند و فرم را برای ثبت بعدی مهیا می کند.";
            guide1.TargetElement = saveNewBtn;
        }
        private void Guide4()
        {
            _msg = "این دکمه اطلاعات کمد را ذخیره می کند و فرم برای ویرایش همان کمد باز می ماند.";
            guide1.TargetElement = SaveBtn;
        }

        #endregion
