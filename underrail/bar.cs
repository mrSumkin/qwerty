using System;
using System.Collections.Generic;

// Token: 0x02001C56 RID: 7254
public abstract class bar : aw2
{
	// Token: 0x06009F1C RID: 40732
	public abstract Type od();

	// Token: 0x06009F1D RID: 40733 RVA: 0x003E33C4 File Offset: 0x003E15C4
	public bar(string A_0) : base(A_0)
	{
	}

	// Token: 0x06009F1E RID: 40734 RVA: 0x003E33D0 File Offset: 0x003E15D0
	public override string wn()
	{
		return "IncreasedBaseAbility";
	}

	// Token: 0x06009F1F RID: 40735 RVA: 0x003E33D8 File Offset: 0x003E15D8
	public override object[] at()
	{
		string text = new bn2().a(this.od()).Name;
		return new object[]
		{
			text,
			bar.a,
			text.ToLowerInvariant()
		};
	}

	// Token: 0x06009F20 RID: 40736 RVA: 0x003E341C File Offset: 0x003E161C
	public override void ar(efk A_0)
	{
		to to = A_0.BaseAbilities.a(this.od());
		to.a(to.f() + bar.a);
	}

	// Token: 0x06009F21 RID: 40737 RVA: 0x003E344C File Offset: 0x003E164C
	public override void @as(efk A_0)
	{
		to to = A_0.BaseAbilities.a(this.od());
		to.a(to.f() - bar.a);
	}

	// Token: 0x06009F22 RID: 40738 RVA: 0x003E347C File Offset: 0x003E167C
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new b4i(base.GetType()));
		return list;
	}

	// Token: 0x04003D95 RID: 15765
	public new static readonly int a = 2;
}
