if (var x != null)
            {
                var response = XtraMessageBox.Show(
                    "text ...",
                    "title",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (response == DialogResult.No) return;
            }

////////////// OR =>

var response = XtraMessageBox.Show(
                "text",
                "caption",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (response == DialogResult.No) return;
