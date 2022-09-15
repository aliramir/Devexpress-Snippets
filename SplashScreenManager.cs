 BeginInvoke(new Action(() =>
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("لطفا شکیبا باشید");
                splashScreenManager1.SetWaitFormDescription("در حال اتصال");

                // Codes ...

                splashScreenManager1.CloseWaitForm();
            }));
