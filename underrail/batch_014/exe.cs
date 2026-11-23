using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x0200181E RID: 6174
[ayj("UseCharm")]
public sealed class exe : m0
{
	// Token: 0x06008368 RID: 33640 RVA: 0x0036E70C File Offset: 0x0036C90C
	public override string y8()
	{
		return "Поцелуй чар";
	}

	// Token: 0x06008369 RID: 33641 RVA: 0x0036E714 File Offset: 0x0036C914
	public override string os()
	{
		return "UseCharm";
	}

	// Token: 0x0600836A RID: 33642 RVA: 0x0036E71C File Offset: 0x0036C91C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600836B RID: 33643 RVA: 0x0036E720 File Offset: 0x0036C920
	public override int bh()
	{
		return 99;
	}

	// Token: 0x0600836C RID: 33644 RVA: 0x0036E724 File Offset: 0x0036C924
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600836D RID: 33645 RVA: 0x0036E728 File Offset: 0x0036C928
	public override IList<string> bi()
	{
		return new List<string>();
	}

	// Token: 0x0600836E RID: 33646 RVA: 0x0036E730 File Offset: 0x0036C930
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600836F RID: 33647 RVA: 0x0036E738 File Offset: 0x0036C938
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			c = c0e.d,
			d = new int?(65)
		};
	}

	// Token: 0x06008370 RID: 33648 RVA: 0x0036E758 File Offset: 0x0036C958
	public override string bm(cnm A_0)
	{
		return "Misc.0";
	}

	// Token: 0x06008371 RID: 33649 RVA: 0x0036E760 File Offset: 0x0036C960
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x06008372 RID: 33650 RVA: 0x0036E764 File Offset: 0x0036C964
	public override string bo(cnm A_0)
	{
		return "Поцелуйте амулет, чтобы повысить его эффективность.";
	}

	// Token: 0x06008373 RID: 33651 RVA: 0x0036E76C File Offset: 0x0036C96C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06008374 RID: 33652 RVA: 0x0036E778 File Offset: 0x0036C978
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x06008375 RID: 33653 RVA: 0x0036E780 File Offset: 0x0036C980
	protected override int br(cnm A_0)
	{
		return 0;
	}

	// Token: 0x06008376 RID: 33654 RVA: 0x0036E784 File Offset: 0x0036C984
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x06008377 RID: 33655 RVA: 0x0036E788 File Offset: 0x0036C988
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x04003284 RID: 12932
	public new static readonly int a = 10;
}
