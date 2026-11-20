using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019B8 RID: 6584
[eiz("MDTEY")]
[Serializable]
public sealed class d2r : d3e, ISerializable
{
	// Token: 0x06008CD1 RID: 36049 RVA: 0x00391E1C File Offset: 0x0039001C
	private d2r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MDTEY:V");
		this.b = (DamageType)A_0.GetValue("MDTEY:D", typeof(DamageType));
	}

	// Token: 0x06008CD2 RID: 36050 RVA: 0x00391E64 File Offset: 0x00390064
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MDTEY:V", this.a);
		info.AddValue("MDTEY:D", this.b);
	}

	// Token: 0x06008CD3 RID: 36051 RVA: 0x00391E98 File Offset: 0x00390098
	public DamageType b()
	{
		return this.b;
	}

	// Token: 0x06008CD4 RID: 36052 RVA: 0x00391EA0 File Offset: 0x003900A0
	public void a(DamageType A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008CD5 RID: 36053 RVA: 0x00391EAC File Offset: 0x003900AC
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008CD6 RID: 36054 RVA: 0x00391EB4 File Offset: 0x003900B4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008CD7 RID: 36055 RVA: 0x00391EC0 File Offset: 0x003900C0
	public d2r()
	{
	}

	// Token: 0x06008CD8 RID: 36056 RVA: 0x00391EC8 File Offset: 0x003900C8
	public d2r(DamageType A_0, int A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06008CD9 RID: 36057 RVA: 0x00391EE0 File Offset: 0x003900E0
	public override string b2()
	{
		if (this.a < 1)
		{
			return qv.a("StaticEffects/ModifyDamageThreshold_Decreased", new object[]
			{
				dh9.a(this.b),
				Math.Abs(this.a)
			});
		}
		return qv.a("StaticEffects/ModifyDamageThreshold_Increased", new object[]
		{
			dh9.a(this.b),
			this.a
		});
	}

	// Token: 0x06008CDA RID: 36058 RVA: 0x00391F64 File Offset: 0x00390164
	public override d3e b3()
	{
		ah ah = new ah();
		this.xx(ah);
		return ah;
	}

	// Token: 0x06008CDB RID: 36059 RVA: 0x00391F80 File Offset: 0x00390180
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			du2 du = A_0.a().Defense.af()[this.b];
			A_0.a().Defense.af()[this.b] = new du2(this.b, Math.Max(0, du.a() + this.a), du.c());
		}
	}

	// Token: 0x06008CDC RID: 36060 RVA: 0x00391FFC File Offset: 0x003901FC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		d2r d2r = (d2r)A_0;
		d2r.b = this.b;
		d2r.a = this.a;
	}

	// Token: 0x040037A8 RID: 14248
	private new int a;

	// Token: 0x040037A9 RID: 14249
	private DamageType b;
}
