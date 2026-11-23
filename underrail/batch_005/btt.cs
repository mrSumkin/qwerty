using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F39 RID: 7993
[ayj("DismountDreadnought")]
public sealed class btt : m0
{
	// Token: 0x0600B9C2 RID: 47554 RVA: 0x00412674 File Offset: 0x00410874
	public override string y8()
	{
		return "Покинуть дредноут";
	}

	// Token: 0x0600B9C3 RID: 47555 RVA: 0x0041267C File Offset: 0x0041087C
	public override string os()
	{
		return "DismountDreadnought";
	}

	// Token: 0x0600B9C4 RID: 47556 RVA: 0x00412684 File Offset: 0x00410884
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B9C5 RID: 47557 RVA: 0x00412688 File Offset: 0x00410888
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600B9C6 RID: 47558 RVA: 0x0041268C File Offset: 0x0041088C
	public override string c1()
	{
		return "Выходит";
	}

	// Token: 0x0600B9C7 RID: 47559 RVA: 0x00412694 File Offset: 0x00410894
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B9C8 RID: 47560 RVA: 0x00412698 File Offset: 0x00410898
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B9C9 RID: 47561 RVA: 0x0041269C File Offset: 0x0041089C
	public btt()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600B9CA RID: 47562 RVA: 0x004126B0 File Offset: 0x004108B0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B9CB RID: 47563 RVA: 0x004126B4 File Offset: 0x004108B4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600B9CC RID: 47564 RVA: 0x004126B8 File Offset: 0x004108B8
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Custom/DismountDreadnought");
	}

	// Token: 0x0600B9CD RID: 47565 RVA: 0x004126C4 File Offset: 0x004108C4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B9CE RID: 47566 RVA: 0x004126D0 File Offset: 0x004108D0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600B9CF RID: 47567 RVA: 0x004126D8 File Offset: 0x004108D8
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B9D0 RID: 47568 RVA: 0x004126E0 File Offset: 0x004108E0
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600B9D1 RID: 47569 RVA: 0x004126E4 File Offset: 0x004108E4
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600B9D2 RID: 47570 RVA: 0x004126E8 File Offset: 0x004108E8
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004393 RID: 17299
	private new List<string> a;
}
