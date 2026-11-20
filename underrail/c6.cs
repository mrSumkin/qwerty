using System;
using System.Runtime.Serialization;

// Token: 0x02000FC0 RID: 4032
[eiz("CIDAVC")]
[Serializable]
public sealed class c6 : dnh, ISerializable
{
	// Token: 0x060052B2 RID: 21170 RVA: 0x0024E948 File Offset: 0x0024CB48
	private c6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("CIDAVC:I", typeof(Guid?));
		this.b = A_0.GetString("CIDAVC:A");
		this.c = A_0.GetBoolean("CIDAVC:N");
		this.d = A_0.GetString("CIDAVC:SF");
		this.e = (bws?)A_0.GetValue("CIDAVC:VT", typeof(bws));
	}

	// Token: 0x060052B3 RID: 21171 RVA: 0x0024E9D0 File Offset: 0x0024CBD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIDAVC:I", this.a);
		info.AddValue("CIDAVC:A", this.b);
		info.AddValue("CIDAVC:N", this.c);
		info.AddValue("CIDAVC:SF", this.d);
		info.AddValue("CIDAVC:VT", this.e);
	}

	// Token: 0x060052B4 RID: 21172 RVA: 0x0024EA44 File Offset: 0x0024CC44
	public string b()
	{
		return this.b;
	}

	// Token: 0x060052B5 RID: 21173 RVA: 0x0024EA4C File Offset: 0x0024CC4C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052B6 RID: 21174 RVA: 0x0024EA58 File Offset: 0x0024CC58
	public Guid? d()
	{
		return this.a;
	}

	// Token: 0x060052B7 RID: 21175 RVA: 0x0024EA60 File Offset: 0x0024CC60
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052B8 RID: 21176 RVA: 0x0024EA6C File Offset: 0x0024CC6C
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060052B9 RID: 21177 RVA: 0x0024EA74 File Offset: 0x0024CC74
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060052BA RID: 21178 RVA: 0x0024EA80 File Offset: 0x0024CC80
	public string e()
	{
		return this.d;
	}

	// Token: 0x060052BB RID: 21179 RVA: 0x0024EA88 File Offset: 0x0024CC88
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060052BC RID: 21180 RVA: 0x0024EA94 File Offset: 0x0024CC94
	public bws? c()
	{
		return this.e;
	}

	// Token: 0x060052BD RID: 21181 RVA: 0x0024EA9C File Offset: 0x0024CC9C
	public void a(bws? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060052BE RID: 21182 RVA: 0x0024EAA8 File Offset: 0x0024CCA8
	public c6()
	{
	}

	// Token: 0x060052BF RID: 21183 RVA: 0x0024EAB4 File Offset: 0x0024CCB4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			b0b b0b = null;
			if (this.a != null && !string.IsNullOrEmpty(this.b))
			{
				aud aud = serviceOrThrow.aqw().n(this.b);
				if (aud != null)
				{
					b0b = new ar7(this.a.Value, aud).ao();
				}
			}
			else
			{
				b0b = serviceOrThrow.aqu().v().b();
			}
			if (b0b != null)
			{
				amc aspect = b0b.GetAspect<amc>();
				if (aspect != null)
				{
					if (aspect.aa().Vehicle != null)
					{
						if (this.d != null)
						{
							flag = (aspect.aa().Vehicle.an().g().Definition.a5() == this.d);
						}
						else if (this.e != null)
						{
							bws bws = aspect.aa().Vehicle.y();
							bws? bws2 = this.e;
							flag = (bws == bws2.GetValueOrDefault() & bws2 != null);
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						flag = false;
					}
				}
			}
		}
		return flag ^ this.c;
	}

	// Token: 0x040021DA RID: 8666
	private Guid? a;

	// Token: 0x040021DB RID: 8667
	private string b;

	// Token: 0x040021DC RID: 8668
	private bool c;

	// Token: 0x040021DD RID: 8669
	private string d;

	// Token: 0x040021DE RID: 8670
	private bws? e;
}
