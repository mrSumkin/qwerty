using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Ouroboros.Core.Logging;

// Token: 0x02000134 RID: 308
public sealed class eni : e0r
{
	// Token: 0x0600077F RID: 1919 RVA: 0x0002006C File Offset: 0x0001E26C
	internal bool a()
	{
		return this.c;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00020074 File Offset: 0x0001E274
	internal void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00020080 File Offset: 0x0001E280
	public cvq atj()
	{
		return null;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00020084 File Offset: 0x0001E284
	public void atk(dyx A_0)
	{
		if (!eni.a(A_0))
		{
			return;
		}
		this.a(A_0.u3(), A_0);
		if (A_0.u4() != null)
		{
			foreach (string text in A_0.u4())
			{
				if (text != null)
				{
					this.a(text, A_0);
				}
			}
		}
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00020108 File Offset: 0x0001E308
	public void atl(IEnumerable<dyx> A_0)
	{
		foreach (dyx dyx in A_0)
		{
			a4y a_ = (a4y)dyx;
			this.atk(a_);
		}
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00020160 File Offset: 0x0001E360
	public bool atm()
	{
		return this.c;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00020168 File Offset: 0x0001E368
	public void atn()
	{
		if (!this.c)
		{
			this.a = new bog(this);
			this.a.Show();
			this.c = true;
		}
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00020194 File Offset: 0x0001E394
	public void ato()
	{
		if (this.c)
		{
			this.a.Close();
			this.a = null;
			this.c = false;
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x000201C0 File Offset: 0x0001E3C0
	private static bool a(dyx A_0)
	{
		cvq cvq = dr3.e();
		if (A_0 == null)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
			{
				string a_ = "[Command Console] Attempted to register 'null' command.";
				cvq.n7(LogSeverity.Error, 102, a_);
			}
			return false;
		}
		if (string.IsNullOrEmpty(A_0.u3()))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
			{
				string a_2 = "[Command Console] Command must have a name.";
				cvq.n7(LogSeverity.Error, 102, a_2);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0002024C File Offset: 0x0001E44C
	private static bool b(string A_0, dyx A_1)
	{
		cvq cvq = dr3.e();
		if (string.IsNullOrEmpty(A_0))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
			{
				string a_ = "[Command Console] Attempted to register an empty alias for command '" + A_1.u3() + "'.";
				cvq.n7(LogSeverity.Error, 102, a_);
			}
			return false;
		}
		if (A_1.u3().Contains(" "))
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
			{
				string a_2 = "[Command Console] Alias may not contain spaces. Command: " + A_1.u3();
				cvq.n7(LogSeverity.Error, 102, a_2);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00020300 File Offset: 0x0001E500
	private void a(string A_0, dyx A_1)
	{
		if (!eni.b(A_0, A_1))
		{
			return;
		}
		if (this.b.Contains(A_0))
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
			{
				string a_ = string.Concat(new string[]
				{
					"[Command Console] Unable to register command alias '",
					A_0,
					"' for command '",
					A_1.u3(),
					"'. Alias already registered."
				});
				cvq.n7(LogSeverity.Error, 102, a_);
				return;
			}
		}
		else
		{
			this.b.Add(A_0, A_1);
		}
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x0002039C File Offset: 0x0001E59C
	internal void a(string A_0, string[] A_1)
	{
		cvq cvq = dr3.e();
		string text = "";
		foreach (string str in A_1)
		{
			text = text + str + ",";
		}
		text = text.TrimEnd(new char[]
		{
			','
		});
		if (this.b.Contains(A_0))
		{
			try
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 102))
				{
					cvq.n7(LogSeverity.Information, 102, string.Concat(new string[]
					{
						"[Command Console] Executing command: ",
						A_0,
						"(",
						text,
						")"
					}));
				}
				(this.b[A_0] as dyx).u6(A_1, this.a);
				return;
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
				{
					cvq.n7(LogSeverity.Error, 102, string.Concat(new string[]
					{
						"[Command Console] Error occurred while executing command '",
						A_0,
						"(",
						text,
						")'. Exception: ",
						ex.ToString()
					}));
				}
				this.a.y9(Color.Red, 12, FontStyle.Regular, ex.ToString());
				return;
			}
		}
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 102))
		{
			cvq.n7(LogSeverity.Error, 102, "[Command Console] Command not found: " + A_0);
		}
		this.a.y9(Color.Red, 12, FontStyle.Regular, "Command not found.");
	}

	// Token: 0x04000567 RID: 1383
	private bog a;

	// Token: 0x04000568 RID: 1384
	private Hashtable b = new Hashtable();

	// Token: 0x04000569 RID: 1385
	private bool c;
}
