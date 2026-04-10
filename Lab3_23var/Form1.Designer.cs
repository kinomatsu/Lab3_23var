namespace Lab3_23var
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblInputHint = new System.Windows.Forms.Label();

            // --- Labels результатов ---
            this.lblStackLabel = new System.Windows.Forms.Label();
            this.lblCounterLabel = new System.Windows.Forms.Label();
            this.lblStackResult = new System.Windows.Forms.Label();
            this.lblCounterResult = new System.Windows.Forms.Label();
            this.lblStackTimeL = new System.Windows.Forms.Label();
            this.lblCounterTimeL = new System.Windows.Forms.Label();
            this.lblStackTime = new System.Windows.Forms.Label();
            this.lblCounterTime = new System.Windows.Forms.Label();
            this.lblStackOpsL = new System.Windows.Forms.Label();
            this.lblCounterOpsL = new System.Windows.Forms.Label();
            this.lblStackOps = new System.Windows.Forms.Label();
            this.lblCounterOps = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // ── txtInput ──
            this.txtInput.Location = new System.Drawing.Point(12, 35);
            this.txtInput.Size = new System.Drawing.Size(560, 23);
            this.txtInput.Font = new System.Drawing.Font("Consolas", 10f);
            this.txtInput.Name = "txtInput";

            // ── lblInputHint ──
            this.lblInputHint.Text = "Введите строку со скобками (до 10 000 символов):";
            this.lblInputHint.Location = new System.Drawing.Point(12, 12);
            this.lblInputHint.Size = new System.Drawing.Size(400, 20);

            // ── btnCheck ──
            this.btnCheck.Text = "Проверить";
            this.btnCheck.Location = new System.Drawing.Point(580, 33);
            this.btnCheck.Size = new System.Drawing.Size(110, 27);
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // ── btnBenchmark ──
            this.btnBenchmark.Text = "Тест производительности";
            this.btnBenchmark.Location = new System.Drawing.Point(700, 33);
            this.btnBenchmark.Size = new System.Drawing.Size(180, 27);
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);

            // ── Результаты — Стек ──
            this.lblStackLabel.Text = "Алгоритм со стеком:";
            this.lblStackLabel.Font = new System.Drawing.Font("Times New Roman", 10f, System.Drawing.FontStyle.Bold);
            this.lblStackLabel.Location = new System.Drawing.Point(12, 75);
            this.lblStackLabel.Size = new System.Drawing.Size(160, 20);

            this.lblStackResult.Text = "—";
            this.lblStackResult.Location = new System.Drawing.Point(180, 75);
            this.lblStackResult.Size = new System.Drawing.Size(120, 20);
            this.lblStackResult.Font = new System.Drawing.Font("Times New Roman", 10f, System.Drawing.FontStyle.Bold);

            this.lblStackTimeL.Text = "Время:";
            this.lblStackTimeL.Location = new System.Drawing.Point(12, 100);
            this.lblStackTimeL.Size = new System.Drawing.Size(60, 20);

            this.lblStackTime.Text = "—";
            this.lblStackTime.Location = new System.Drawing.Point(80, 100);
            this.lblStackTime.Size = new System.Drawing.Size(150, 20);

            this.lblStackOpsL.Text = "Операций:";
            this.lblStackOpsL.Location = new System.Drawing.Point(240, 100);
            this.lblStackOpsL.Size = new System.Drawing.Size(70, 20);

            this.lblStackOps.Text = "—";
            this.lblStackOps.Location = new System.Drawing.Point(315, 100);
            this.lblStackOps.Size = new System.Drawing.Size(100, 20);

            // ── Результаты — Счётчик ──
            this.lblCounterLabel.Text = "Алгоритм со счётчиком:";
            this.lblCounterLabel.Font = new System.Drawing.Font("Times New Roman", 10f, System.Drawing.FontStyle.Bold);
            this.lblCounterLabel.Location = new System.Drawing.Point(12, 130);
            this.lblCounterLabel.Size = new System.Drawing.Size(170, 20);

            this.lblCounterResult.Text = "—";
            this.lblCounterResult.Location = new System.Drawing.Point(190, 130);
            this.lblCounterResult.Size = new System.Drawing.Size(120, 20);
            this.lblCounterResult.Font = new System.Drawing.Font("Times New Roman", 10f, System.Drawing.FontStyle.Bold);

            this.lblCounterTimeL.Text = "Время:";
            this.lblCounterTimeL.Location = new System.Drawing.Point(12, 155);
            this.lblCounterTimeL.Size = new System.Drawing.Size(60, 20);

            this.lblCounterTime.Text = "—";
            this.lblCounterTime.Location = new System.Drawing.Point(80, 155);
            this.lblCounterTime.Size = new System.Drawing.Size(150, 20);

            this.lblCounterOpsL.Text = "Операций:";
            this.lblCounterOpsL.Location = new System.Drawing.Point(240, 155);
            this.lblCounterOpsL.Size = new System.Drawing.Size(70, 20);

            this.lblCounterOps.Text = "—";
            this.lblCounterOps.Location = new System.Drawing.Point(315, 155);
            this.lblCounterOps.Size = new System.Drawing.Size(100, 20);

            // ── Таблица ──
            this.lblTableTitle.Text = "Таблица сравнения производительности:";
            this.lblTableTitle.Font = new System.Drawing.Font("Times New Roman", 10f, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.Location = new System.Drawing.Point(12, 185);
            this.lblTableTitle.Size = new System.Drawing.Size(350, 20);

            this.dgvResults.Location = new System.Drawing.Point(12, 210);
            this.dgvResults.Size = new System.Drawing.Size(870, 200);
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvResults.Columns.Add("colSize", "Размер строки");
            this.dgvResults.Columns.Add("colTime1", "Время (стек), мс");
            this.dgvResults.Columns.Add("colTime2", "Время (счётчик), мс");
            this.dgvResults.Columns.Add("colOps1", "Операций (стек)");
            this.dgvResults.Columns.Add("colOps2", "Операций (счётчик)");

            // ── Form ──
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Text = "Лабораторная работа №3 — Вариант 23: Проверка скобочной последовательности";
            this.Font = new System.Drawing.Font("Times New Roman", 9f);
            this.Name = "Form1";

            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInputHint);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBenchmark);
            this.Controls.Add(this.lblStackLabel);
            this.Controls.Add(this.lblStackResult);
            this.Controls.Add(this.lblStackTimeL);
            this.Controls.Add(this.lblStackTime);
            this.Controls.Add(this.lblStackOpsL);
            this.Controls.Add(this.lblStackOps);
            this.Controls.Add(this.lblCounterLabel);
            this.Controls.Add(this.lblCounterResult);
            this.Controls.Add(this.lblCounterTimeL);
            this.Controls.Add(this.lblCounterTime);
            this.Controls.Add(this.lblCounterOpsL);
            this.Controls.Add(this.lblCounterOps);
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.dgvResults);

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblInputHint;
        private System.Windows.Forms.Label lblStackLabel;
        private System.Windows.Forms.Label lblCounterLabel;
        private System.Windows.Forms.Label lblStackResult;
        private System.Windows.Forms.Label lblCounterResult;
        private System.Windows.Forms.Label lblStackTimeL;
        private System.Windows.Forms.Label lblCounterTimeL;
        private System.Windows.Forms.Label lblStackTime;
        private System.Windows.Forms.Label lblCounterTime;
        private System.Windows.Forms.Label lblStackOpsL;
        private System.Windows.Forms.Label lblCounterOpsL;
        private System.Windows.Forms.Label lblStackOps;
        private System.Windows.Forms.Label lblCounterOps;
        private System.Windows.Forms.Label lblTableTitle;
    }
}
