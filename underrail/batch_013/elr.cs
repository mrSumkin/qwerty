using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02001EDB RID: 7899
public abstract class elr : c0z
{
	// Token: 0x0600B365 RID: 45925 RVA: 0x0040680C File Offset: 0x00404A0C
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B367 RID: 45927 RVA: 0x0040681C File Offset: 0x00404A1C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0.b8().Vehicle != null && Enumerable.Any<aia>(A_0.b8().Vehicle.ai(), new Func<aia, bool>(this.a));
	}

	// Token: 0x0600B368 RID: 45928 RVA: 0x00406874 File Offset: 0x00404A74
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}
}
