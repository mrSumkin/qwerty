using System;
using System.Runtime.Serialization;

// Token: 0x02001B1E RID: 6942
[eiz("TK0")]
[Serializable]
public sealed class s1 : els, ISerializable
{
	// Token: 0x06009632 RID: 38450 RVA: 0x003ACC34 File Offset: 0x003AAE34
	private s1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.g = (A_0.GetValue("TK0:M", typeof(ba)) as ba);
		this.h = (A_0.GetValue("TK0:A", typeof(d9)) as d9);
		this.i = (A_0.GetValue("TK0:H", typeof(etj)) as etj);
		if (ell.a() >= 218)
		{
			this.j = (A_0.GetValue("TK0:O", typeof(i0)) as i0);
			this.k = (A_0.GetValue("TK0:T", typeof(bjo)) as bjo);
		}
	}

	// Token: 0x06009633 RID: 38451 RVA: 0x003ACCF8 File Offset: 0x003AAEF8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TK0:M", this.g);
		info.AddValue("TK0:A", this.h);
		info.AddValue("TK0:H", this.i);
		info.AddValue("TK0:O", this.j);
		info.AddValue("TK0:T", this.k);
	}

	// Token: 0x06009634 RID: 38452 RVA: 0x003ACD64 File Offset: 0x003AAF64
	public s1(int A_0, string A_1 = "Status.Tackled") : base("tackled", "В захвате", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = A_1;
		base.MaxStacks = s1.d;
		base.Stacking = axm.b;
		this.g = new ba
		{
			Priority = 2147483637
		};
		this.h = new d9
		{
			Priority = 2147483637
		};
		this.i = new etj
		{
			Priority = 2147483637
		};
		this.j = new i0();
		this.k = new bjo();
		base.StaticEffects.Add(this.g);
		base.StaticEffects.Add(this.h);
		base.StaticEffects.Add(this.i);
		base.StaticEffects.Add(this.j);
		base.StaticEffects.Add(this.k);
		this.a();
	}

	// Token: 0x06009635 RID: 38453 RVA: 0x003ACE58 File Offset: 0x003AB058
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Tackled", new object[]
		{
			-this.g.a,
			-this.h.a,
			(int)(-this.i.b() * 100.0)
		});
	}

	// Token: 0x06009636 RID: 38454 RVA: 0x003ACEBC File Offset: 0x003AB0BC
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009637 RID: 38455 RVA: 0x003ACECC File Offset: 0x003AB0CC
	private void a()
	{
		this.g.a = base.Stacks * -s1.a;
		this.h.a = base.Stacks * -s1.b;
		this.i.a((double)base.Stacks * -s1.c);
		this.j.Amount = (float)base.Stacks * -s1.e;
		this.k.WeaponSpeedModification = (float)base.Stacks * s1.f;
	}

	// Token: 0x040039CA RID: 14794
	public new static readonly int a = 8;

	// Token: 0x040039CB RID: 14795
	public static readonly int b = 3;

	// Token: 0x040039CC RID: 14796
	public new static readonly double c = 0.07;

	// Token: 0x040039CD RID: 14797
	public new static readonly int d = 5;

	// Token: 0x040039CE RID: 14798
	public new static readonly float e = 0.1f;

	// Token: 0x040039CF RID: 14799
	public static readonly float f = 0.2f;

	// Token: 0x040039D0 RID: 14800
	private ba g;

	// Token: 0x040039D1 RID: 14801
	private d9 h;

	// Token: 0x040039D2 RID: 14802
	private new etj i;

	// Token: 0x040039D3 RID: 14803
	private i0 j;

	// Token: 0x040039D4 RID: 14804
	private bjo k;
}
