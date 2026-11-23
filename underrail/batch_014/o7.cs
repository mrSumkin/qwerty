using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F50 RID: 3920
[eiz("CHIOTC")]
[Serializable]
public sealed class o7 : dnh, ISerializable
{
	// Token: 0x06004F53 RID: 20307 RVA: 0x0023C7A4 File Offset: 0x0023A9A4
	private o7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (a0)A_0.GetValue("CHIOTC:IC", typeof(a0));
		this.b = A_0.GetBoolean("CHIOTC:CIP");
		this.c = (Guid?)A_0.GetValue("CHIOTC:ID", typeof(Guid?));
		this.d = A_0.GetString("CHIOTC:A");
		this.e = A_0.GetBoolean("CHIOTC:I");
	}

	// Token: 0x06004F54 RID: 20308 RVA: 0x0023C82C File Offset: 0x0023AA2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CHIOTC:IC", this.a);
		info.AddValue("CHIOTC:CIP", this.b);
		info.AddValue("CHIOTC:ID", this.c);
		info.AddValue("CHIOTC:A", this.d);
		info.AddValue("CHIOTC:I", this.e);
	}

	// Token: 0x06004F55 RID: 20309 RVA: 0x0023C8A0 File Offset: 0x0023AAA0
	public a0 d()
	{
		return this.a;
	}

	// Token: 0x06004F56 RID: 20310 RVA: 0x0023C8A8 File Offset: 0x0023AAA8
	public void a(a0 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004F57 RID: 20311 RVA: 0x0023C8B4 File Offset: 0x0023AAB4
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06004F58 RID: 20312 RVA: 0x0023C8BC File Offset: 0x0023AABC
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x0023C8C8 File Offset: 0x0023AAC8
	public string c()
	{
		return this.d;
	}

	// Token: 0x06004F5A RID: 20314 RVA: 0x0023C8D0 File Offset: 0x0023AAD0
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x0023C8DC File Offset: 0x0023AADC
	public Guid? e()
	{
		return this.c;
	}

	// Token: 0x06004F5C RID: 20316 RVA: 0x0023C8E4 File Offset: 0x0023AAE4
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06004F5D RID: 20317 RVA: 0x0023C8F0 File Offset: 0x0023AAF0
	public bool a()
	{
		return this.e;
	}

	// Token: 0x06004F5E RID: 20318 RVA: 0x0023C8F8 File Offset: 0x0023AAF8
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06004F5F RID: 20319 RVA: 0x0023C904 File Offset: 0x0023AB04
	public o7()
	{
	}

	// Token: 0x06004F60 RID: 20320 RVA: 0x0023C910 File Offset: 0x0023AB10
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			c5x c5x = null;
			if (this.b)
			{
				c5x = (serviceOrThrow.aqu().v().b() as c5x);
			}
			else if (this.c != null && !string.IsNullOrEmpty(this.d))
			{
				aud aud = serviceOrThrow.aqw().n(this.d);
				if (aud != null)
				{
					c5x = (new ar7(this.c.Value, aud).ao() as c5x);
				}
			}
			else if (!(A_0.get_Item(c49.a) as c5x).IsPlayer)
			{
				c5x = (A_0.GetPropertyValue(c49.a) as c5x);
			}
			else
			{
				c5x = (A_0.GetPropertyValue(c49.b) as c5x);
			}
			if (c5x != null && c5x.h.b != null)
			{
				using (List<coh>.Enumerator enumerator = Enumerable.ToList<coh>(c5x.h.b.aa().Bag.z2()).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Definition.bi() == this.a)
						{
							flag = true;
							break;
						}
					}
				}
				using (List<coh>.Enumerator enumerator = c5x.h.b.aa().Gear.i().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Definition.bi() == this.a)
						{
							flag = true;
							break;
						}
					}
				}
			}
		}
		return flag ^ this.e;
	}

	// Token: 0x06004F61 RID: 20321 RVA: 0x0023CAFC File Offset: 0x0023ACFC
	public string f()
	{
		return "CharacterHasItemOfTradingCategoryCondition";
	}

	// Token: 0x04002086 RID: 8326
	private a0 a;

	// Token: 0x04002087 RID: 8327
	private bool b;

	// Token: 0x04002088 RID: 8328
	private Guid? c;

	// Token: 0x04002089 RID: 8329
	private string d;

	// Token: 0x0400208A RID: 8330
	private bool e;
}
