using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001A0C RID: 6668
[eiz("MSCDP")]
[Serializable]
public sealed class ekr : d91, d7s, ISerializable
{
	// Token: 0x06008FFF RID: 36863 RVA: 0x003993F0 File Offset: 0x003975F0
	private ekr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (SpecialCategory)A_0.GetValue("MSCDP:C", typeof(SpecialCategory));
	}

	// Token: 0x06009000 RID: 36864 RVA: 0x0039941C File Offset: 0x0039761C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSCDP:C", this.a);
	}

	// Token: 0x06009001 RID: 36865 RVA: 0x0039943C File Offset: 0x0039763C
	public SpecialCategory a()
	{
		return this.a;
	}

	// Token: 0x06009002 RID: 36866 RVA: 0x00399444 File Offset: 0x00397644
	public void a(SpecialCategory A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009003 RID: 36867 RVA: 0x00399450 File Offset: 0x00397650
	public override bool ae5()
	{
		return base.b() < 0.0;
	}

	// Token: 0x06009004 RID: 36868 RVA: 0x00399464 File Offset: 0x00397664
	public ekr()
	{
	}

	// Token: 0x06009005 RID: 36869 RVA: 0x0039946C File Offset: 0x0039766C
	public ekr(SpecialCategory A_0, double A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x06009006 RID: 36870 RVA: 0x0039947C File Offset: 0x0039767C
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		A_0.a().SpecialCategoryModifiers[this.a].a += base.b();
	}

	// Token: 0x06009007 RID: 36871 RVA: 0x003994BC File Offset: 0x003976BC
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ekr)A_0).a = this.a;
	}

	// Token: 0x06009008 RID: 36872 RVA: 0x003994D8 File Offset: 0x003976D8
	public override string b2()
	{
		string arg;
		if (!ccs.a.TryGetValue(this.a, out arg))
		{
			arg = "неизвестная способность";
		}
		if (base.b() < 0.0)
		{
			return string.Format("Урон от {0} уменьшен на {1}%", arg, (int)Math.Abs(base.b() * 100.0));
		}
		return string.Format("Урон от {0} увеличен на {1}%", arg, (int)(base.b() * 100.0));
	}

	// Token: 0x06009009 RID: 36873 RVA: 0x00399560 File Offset: 0x00397760
	public override d3e b3()
	{
		ekr ekr = new ekr();
		this.xx(ekr);
		return ekr;
	}

	// Token: 0x0600900A RID: 36874 RVA: 0x0039957C File Offset: 0x0039777C
	public void cn(d3e A_0)
	{
		ekr ekr = A_0 as ekr;
		base.a(base.b() + ekr.b());
	}

	// Token: 0x0600900B RID: 36875 RVA: 0x003995A4 File Offset: 0x003977A4
	public bool co(d3e A_0)
	{
		ekr ekr = A_0 as ekr;
		return ekr != null && ekr.a == this.a && ekr.Condition == base.Condition;
	}

	// Token: 0x04003801 RID: 14337
	private new SpecialCategory a;
}
