using System;
using Ouroboros.Core.Logging;

// Token: 0x020001A5 RID: 421
public class amo : ajx
{
	// Token: 0x06000C21 RID: 3105 RVA: 0x0003089C File Offset: 0x0002EA9C
	public amo(bso A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x000308C8 File Offset: 0x0002EAC8
	public void q0(e6d A_0, cp9 A_1)
	{
		if (this.a.aau() != null)
		{
			this.a.aau().iv(A_0, A_1);
		}
		if (this.a.aao() && this.a.c() != null && this.a.aaq())
		{
			bool a_ = false;
			string text = this.a.aas();
			if (this.a.a() != null && this.a.a().ax() != null && this.a.aa8() != null)
			{
				a_ = this.a.aa8().iq(this.a.a().ax());
				if (!string.IsNullOrEmpty(this.a.a().ax().b()))
				{
					text = this.a.a().ax().b();
				}
			}
			else if (this.a.aa8() != null)
			{
				string text2 = null;
				euz euz = this.a.aa8();
				while (euz.Parent != null && euz.IsPrivateComponent && !euz.ForceProvidesCursor)
				{
					euz = euz.Parent;
				}
				if (this.a.aau() != null)
				{
					text2 = this.a.aau().afm(euz);
				}
				if (string.IsNullOrEmpty(text2))
				{
					text2 = euz.CursorName;
				}
				if (!string.IsNullOrEmpty(text2))
				{
					text = text2;
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				aiu aiu = this.a.c().o8(text);
				if (aiu == null)
				{
					cvq cvq = dr3.e();
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 110))
					{
						string a_2 = ki.a("[GUI] - Failed to retrieve cursor with name {0}. Cursor will not be drawn.", new object[]
						{
							text
						});
						cvq.n7(LogSeverity.Error, 110, a_2);
						return;
					}
				}
				else
				{
					aiu.ob(A_0, A_1, a_);
				}
			}
		}
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00030ACC File Offset: 0x0002ECCC
	public Guid qe()
	{
		return this.b;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00030AD4 File Offset: 0x0002ECD4
	public string y8()
	{
		return this.c;
	}

	// Token: 0x04000734 RID: 1844
	private bso a;

	// Token: 0x04000735 RID: 1845
	private readonly Guid b = new Guid("{7F355B27-B05B-4f96-8A96-BCCCA68A795E}");

	// Token: 0x04000736 RID: 1846
	private string c = "OuroborosGUIRenderer";
}
