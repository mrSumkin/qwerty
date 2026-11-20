using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001A1C RID: 6684
[eiz("MSFE2")]
[Serializable]
public sealed class bdz : dts, em0, ISerializable
{
	// Token: 0x060090A8 RID: 37032 RVA: 0x0039B050 File Offset: 0x00399250
	private bdz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("MSFE2:S", typeof(List<string>)) as List<string>);
		this.b = A_0.GetString("MSFE2:N");
		if (this.b == "Пси-навыки" && this.a != null && !this.a.Contains("Temporal Manipulation"))
		{
			this.a.Add("Temporal Manipulation");
		}
	}

	// Token: 0x060090A9 RID: 37033 RVA: 0x0039B0DC File Offset: 0x003992DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSFE2:S", this.a);
		info.AddValue("MSFE2:N", this.b);
	}

	// Token: 0x060090AA RID: 37034 RVA: 0x0039B108 File Offset: 0x00399308
	public List<string> a()
	{
		return this.a;
	}

	// Token: 0x060090AB RID: 37035 RVA: 0x0039B110 File Offset: 0x00399310
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060090AC RID: 37036 RVA: 0x0039B11C File Offset: 0x0039931C
	public string b()
	{
		return this.b;
	}

	// Token: 0x060090AD RID: 37037 RVA: 0x0039B124 File Offset: 0x00399324
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060090AE RID: 37038 RVA: 0x0039B130 File Offset: 0x00399330
	public bdz()
	{
		this.a = new List<string>();
	}

	// Token: 0x060090AF RID: 37039 RVA: 0x0039B144 File Offset: 0x00399344
	public bdz(string[] A_0 = null, int A_1 = 0, string A_2 = null) : base(A_1)
	{
		if (A_0 != null)
		{
			this.a = new List<string>(A_0);
		}
		else
		{
			this.a = new List<string>();
		}
		this.b = A_2;
	}

	// Token: 0x060090B0 RID: 37040 RVA: 0x0039B178 File Offset: 0x00399378
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		foreach (string text in this.a)
		{
			if (A_0.a() != null && !string.IsNullOrEmpty(text))
			{
				csn csn = A_0.a().Skills.a(text);
				if (csn != null)
				{
					csn csn2 = csn;
					csn2.b(csn2.g() + base.c());
					csn.a();
				}
			}
		}
	}

	// Token: 0x060090B1 RID: 37041 RVA: 0x0039B21C File Offset: 0x0039941C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		bdz bdz = (bdz)A_0;
		bdz.b = this.b;
		if (this.a != null)
		{
			bdz.a = new List<string>(this.a);
		}
	}

	// Token: 0x060090B2 RID: 37042 RVA: 0x0039B260 File Offset: 0x00399460
	public override d3e b3()
	{
		bdz bdz = new bdz();
		this.xx(bdz);
		return bdz;
	}

	// Token: 0x060090B3 RID: 37043 RVA: 0x0039B27C File Offset: 0x0039947C
	public override string b2()
	{
		string text = "";
		if (this.a.Count > 0)
		{
			if (!string.IsNullOrEmpty(this.b))
			{
				text = dh9.c(this.b);
				if (string.IsNullOrEmpty(text))
				{
					text = this.b;
				}
			}
			else
			{
				for (int i = 0; i < this.a.Count; i++)
				{
					string text2 = dh9.a("SkillEnum." + this.a[i]);
					if (string.IsNullOrEmpty(text2))
					{
						text2 = this.a[i];
					}
					if (i != 0)
					{
						if (i == this.a.Count - 1)
						{
							text = string.Concat(new string[]
							{
								text,
								", ",
								dh9.c("and"),
								" ",
								text2
							});
						}
						else
						{
							text = text + ", " + text2;
						}
					}
					else
					{
						text += text2;
					}
				}
			}
		}
		else
		{
			text = qv.b("StaticEffects/ModifySkillsFlat_Nothing");
		}
		if (base.c() < 0)
		{
			return qv.a("StaticEffects/ModifySkillsFlat_Decreased", new object[]
			{
				text,
				Math.Abs(base.c())
			});
		}
		return qv.a("StaticEffects/ModifySkillsFlat_Increased", new object[]
		{
			text,
			base.c()
		});
	}

	// Token: 0x04003814 RID: 14356
	private new List<string> a;

	// Token: 0x04003815 RID: 14357
	private string b;
}
