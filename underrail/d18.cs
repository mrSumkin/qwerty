using System;
using Ouroboros.Core.Logging;

// Token: 0x02000567 RID: 1383
public sealed class d18 : acj
{
	// Token: 0x060023DB RID: 9179 RVA: 0x000C6BF0 File Offset: 0x000C4DF0
	public void aqn(bk3 A_0, Version A_1)
	{
		foreach (dqb dqb in ars.d())
		{
			if (A_1 < dqb.TargetVersion)
			{
				try
				{
					if (!dqb.Patch.eq(A_0))
					{
						dux.b(LogSeverity.Warning, "Failed to apply item patch '{0}' to item '{1}'.", new object[]
						{
							dqb.PatchId,
							A_0.az()
						});
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to apply item patch '{0}' to item '{1}'.", new object[]
					{
						dqb.PatchId,
						A_0.az()
					});
				}
			}
		}
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x000C6CC4 File Offset: 0x000C4EC4
	public void aqo(coh A_0, Version A_1)
	{
		foreach (dqb dqb in ars.d())
		{
			if (A_1 < dqb.TargetVersion)
			{
				try
				{
					if (!dqb.Patch.er(A_0))
					{
						dux.b(LogSeverity.Warning, "Failed to apply item instance patch '{0}' to item '{1}'.", new object[]
						{
							dqb.PatchId,
							A_0.Definition.az()
						});
					}
				}
				catch (Exception a_)
				{
					dux.a(LogSeverity.Error, a_, "Failed to apply item instance patch '{0}' to item '{1}'.", new object[]
					{
						dqb.PatchId,
						A_0.Definition.az()
					});
				}
			}
		}
	}
}
