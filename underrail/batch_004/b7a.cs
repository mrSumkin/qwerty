using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A16 RID: 6678
[eiz("MWS")]
[Serializable]
public sealed class b7a : d3e, ISerializable
{
	// Token: 0x06009065 RID: 36965 RVA: 0x0039A3E0 File Offset: 0x003985E0
	private b7a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetSingle("MWS:A");
		this.b = (WeaponSubtype)A_0.GetValue("MWS:S", typeof(WeaponSubtype));
		this.c = A_0.GetInt32("MWS:P");
		this.d = A_0.GetInt32("MWS:C");
	}

	// Token: 0x06009066 RID: 36966 RVA: 0x0039A448 File Offset: 0x00398648
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MWS:A", this.a);
		info.AddValue("MWS:S", this.b);
		info.AddValue("MWS:P", this.c);
		info.AddValue("MWS:C", this.d);
	}

	// Token: 0x06009067 RID: 36967 RVA: 0x0039A4A8 File Offset: 0x003986A8
	public float c()
	{
		return this.a;
	}

	// Token: 0x06009068 RID: 36968 RVA: 0x0039A4B0 File Offset: 0x003986B0
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009069 RID: 36969 RVA: 0x0039A4BC File Offset: 0x003986BC
	public WeaponSubtype a()
	{
		return this.b;
	}

	// Token: 0x0600906A RID: 36970 RVA: 0x0039A4C4 File Offset: 0x003986C4
	public void a(WeaponSubtype A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600906B RID: 36971 RVA: 0x0039A4D0 File Offset: 0x003986D0
	public int b()
	{
		return this.d;
	}

	// Token: 0x0600906C RID: 36972 RVA: 0x0039A4D8 File Offset: 0x003986D8
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600906D RID: 36973 RVA: 0x0039A4E4 File Offset: 0x003986E4
	public b7a()
	{
	}

	// Token: 0x0600906E RID: 36974 RVA: 0x0039A4EC File Offset: 0x003986EC
	public b7a(float A_0, int A_1, WeaponSubtype A_2, int A_3 = 0)
	{
		this.a = A_0;
		this.d = A_1;
		this.b = A_2;
		this.c = A_3;
	}

	// Token: 0x0600906F RID: 36975 RVA: 0x0039A514 File Offset: 0x00398714
	public override string b2()
	{
		string arg = as3.ak[this.b].ToLowerInvariant();
		if (this.d >= 0)
		{
			return string.Format("Стоимость в очках действия атак {0} увеличена на {1}.", arg, this.d);
		}
		return string.Format("Стоимость в очках действия атак {0} уменьшена на {1}.", arg, Math.Abs(this.d));
	}

	// Token: 0x06009070 RID: 36976 RVA: 0x0039A578 File Offset: 0x00398778
	public override d3e b3()
	{
		b7a b7a = new b7a();
		this.xx(b7a);
		return b7a;
	}

	// Token: 0x06009071 RID: 36977 RVA: 0x0039A594 File Offset: 0x00398794
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		b7a b7a = (b7a)A_0;
		b7a.d = this.d;
		b7a.c = this.c;
		b7a.a = this.a;
		b7a.b = this.b;
	}

	// Token: 0x06009072 RID: 36978 RVA: 0x0039A5D8 File Offset: 0x003987D8
	protected override void @in(ll A_0)
	{
		if (A_0 != null && A_0.a() != null)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.a().Offense.u().TypedDefinition);
			WeaponSubtype weaponSubtype2 = this.b;
			if (weaponSubtype.GetValueOrDefault() == weaponSubtype2 & weaponSubtype != null)
			{
				dcu dcu = A_0.a().Offense;
				dcu.a(dcu.ax() + this.a);
				dcu dcu2 = A_0.a().Offense;
				dcu2.e(dcu2.j() + this.d);
			}
		}
	}

	// Token: 0x0400380B RID: 14347
	private new float a;

	// Token: 0x0400380C RID: 14348
	private WeaponSubtype b;

	// Token: 0x0400380D RID: 14349
	private int c;

	// Token: 0x0400380E RID: 14350
	private int d;
}
