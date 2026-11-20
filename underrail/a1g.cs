using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020004C6 RID: 1222
[eiz("T13")]
[Serializable]
public sealed class a1g : esc, ISerializable
{
	// Token: 0x06001F33 RID: 7987 RVA: 0x000AC8EC File Offset: 0x000AAAEC
	private a1g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("T13:IC");
		this.b = A_0.GetInt32("T13:S");
		this.c = A_0.GetBoolean("T13:I");
		this.d = A_0.GetBoolean("T13:SG");
		this.e = (A_0.GetValue("T13:N", typeof(Guid?)) as Guid?);
		if (ell.a() >= 549)
		{
			this.f = A_0.GetBoolean("T13:P");
		}
		if (ell.a() >= 689)
		{
			this.g = (A_0.GetValue("T13:ST", typeof(bool?)) as bool?);
		}
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x000AC9CC File Offset: 0x000AABCC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T13:IC", this.a);
		info.AddValue("T13:S", this.b);
		info.AddValue("T13:I", this.c);
		info.AddValue("T13:SG", this.d);
		info.AddValue("T13:N", this.e);
		info.AddValue("T13:P", this.f);
		info.AddValue("T13:ST", this.g);
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x000ACA64 File Offset: 0x000AAC64
	public string d()
	{
		return this.a;
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x000ACA6C File Offset: 0x000AAC6C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x000ACA78 File Offset: 0x000AAC78
	public int b()
	{
		return this.b;
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x000ACA80 File Offset: 0x000AAC80
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x000ACA8C File Offset: 0x000AAC8C
	public bool g()
	{
		return this.c;
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000ACA94 File Offset: 0x000AAC94
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000ACAA0 File Offset: 0x000AACA0
	public bool e()
	{
		return this.d;
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000ACAA8 File Offset: 0x000AACA8
	public void c(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x000ACAB4 File Offset: 0x000AACB4
	public Guid? a()
	{
		return this.e;
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x000ACABC File Offset: 0x000AACBC
	public void a(Guid? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x000ACAC8 File Offset: 0x000AACC8
	public bool c()
	{
		return this.f;
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000ACAD0 File Offset: 0x000AACD0
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x000ACADC File Offset: 0x000AACDC
	public bool? f()
	{
		return this.g;
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x000ACAE4 File Offset: 0x000AACE4
	public void a(bool? A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x000ACAF0 File Offset: 0x000AACF0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.a != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area != null)
		{
			efk efk = null;
			if (this.e != null)
			{
				EntityAspectReference<amc, amc> entityAspectReference = new EntityAspectReference<amc, amc>(serviceOrThrow.aqu().v().b().Area, this.e.Value);
				if (entityAspectReference.ao() != null)
				{
					efk = entityAspectReference.ao().aa();
				}
			}
			else
			{
				efk = serviceOrThrow.aqu().v();
			}
			if (efk != null)
			{
				efk efk2;
				if (this.c)
				{
					efk2 = efk;
					efk = serviceOrThrow.aqu().v();
				}
				else
				{
					efk2 = serviceOrThrow.aqu().v();
				}
				coh coh = efk.a(this.a, this.b, this.d);
				if (coh != null)
				{
					if (this.f)
					{
						if (this.c)
						{
							a7v.a(new aub(coh));
						}
						else
						{
							a7v.a(new bou(coh));
						}
					}
					if (this.g != null)
					{
						coh.Stealable = this.g.Value;
					}
					efk2.Bag.z3(coh, true);
				}
			}
		}
		return 1;
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x000ACC70 File Offset: 0x000AAE70
	public a1g()
	{
	}

	// Token: 0x040013B8 RID: 5048
	private string a;

	// Token: 0x040013B9 RID: 5049
	private int b = 1;

	// Token: 0x040013BA RID: 5050
	private bool c;

	// Token: 0x040013BB RID: 5051
	private bool d = true;

	// Token: 0x040013BC RID: 5052
	private Guid? e;

	// Token: 0x040013BD RID: 5053
	private bool f;

	// Token: 0x040013BE RID: 5054
	private bool? g;
}
