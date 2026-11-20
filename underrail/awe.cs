using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A29 RID: 6697
[eiz("I01")]
[Serializable]
public sealed class awe : d3e, d7s, ISerializable
{
	// Token: 0x060090FA RID: 37114 RVA: 0x0039BF14 File Offset: 0x0039A114
	private awe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (CharacterImmunities)A_0.GetValue("I01:I", typeof(CharacterImmunities));
	}

	// Token: 0x060090FB RID: 37115 RVA: 0x0039BF40 File Offset: 0x0039A140
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("I01:I", this.a);
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x060090FC RID: 37116 RVA: 0x0039BF60 File Offset: 0x0039A160
	// (set) Token: 0x060090FD RID: 37117 RVA: 0x0039BF68 File Offset: 0x0039A168
	public CharacterImmunities Immunity
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060090FE RID: 37118 RVA: 0x0039BF74 File Offset: 0x0039A174
	public awe()
	{
	}

	// Token: 0x060090FF RID: 37119 RVA: 0x0039BF7C File Offset: 0x0039A17C
	public awe(CharacterImmunities A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009100 RID: 37120 RVA: 0x0039BF8C File Offset: 0x0039A18C
	public void cn(d3e A_0)
	{
	}

	// Token: 0x06009101 RID: 37121 RVA: 0x0039BF94 File Offset: 0x0039A194
	public bool co(d3e A_0)
	{
		awe awe = A_0 as awe;
		return awe != null && awe.a == this.a && awe.Condition == base.Condition;
	}

	// Token: 0x06009102 RID: 37122 RVA: 0x0039BFD0 File Offset: 0x0039A1D0
	protected override void @in(ll A_0)
	{
		A_0.a().Immunities |= this.a;
	}

	// Token: 0x06009103 RID: 37123 RVA: 0x0039BFEC File Offset: 0x0039A1EC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((awe)A_0).a = this.a;
	}

	// Token: 0x06009104 RID: 37124 RVA: 0x0039C008 File Offset: 0x0039A208
	public override string b2()
	{
		return qv.a("StaticEffects/immunity", new object[]
		{
			ts.a(this.a)
		});
	}

	// Token: 0x06009105 RID: 37125 RVA: 0x0039C02C File Offset: 0x0039A22C
	public override d3e b3()
	{
		awe awe = new awe();
		this.xx(awe);
		return awe;
	}

	// Token: 0x0400381D RID: 14365
	private new CharacterImmunities a;
}
