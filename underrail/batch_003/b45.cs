using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001AFD RID: 6909
[eiz("WSBSE")]
[Serializable]
public sealed class b45 : els, ISerializable
{
	// Token: 0x060095A2 RID: 38306 RVA: 0x003AACCC File Offset: 0x003A8ECC
	private b45(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("WSBSE:N");
	}

	// Token: 0x060095A3 RID: 38307 RVA: 0x003AACE8 File Offset: 0x003A8EE8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WSBSE:N", this.a);
	}

	// Token: 0x060095A4 RID: 38308 RVA: 0x003AAD04 File Offset: 0x003A8F04
	public string a()
	{
		return this.a;
	}

	// Token: 0x060095A5 RID: 38309 RVA: 0x003AAD0C File Offset: 0x003A8F0C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060095A6 RID: 38310 RVA: 0x003AAD18 File Offset: 0x003A8F18
	public b45(string A_0) : base(A_0 + "WorkbenchBonus", A_0 + " бонус", ci8.b)
	{
		this.a = A_0;
		base.Duration = 0;
		base.Icon = "Abilities.71";
		base.Stacking = axm.c;
		List<d3e> list = base.StaticEffects;
		bxb bxb = new bxb(this.a, c6o.a);
		bxb.a(true);
		bxb.Priority = int.MaxValue;
		list.Add(bxb);
	}

	// Token: 0x060095A7 RID: 38311 RVA: 0x003AAD90 File Offset: 0x003A8F90
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/WorkbenchSkillBonus", new object[]
		{
			this.a,
			(int)(c6o.a * 100f)
		});
	}

	// Token: 0x0400399B RID: 14747
	private new string a;
}
