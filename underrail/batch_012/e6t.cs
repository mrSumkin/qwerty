using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000F5E RID: 3934
[eiz("SGSTPBHC")]
[Serializable]
public sealed class e6t : dth, ISerializable
{
	// Token: 0x06004FBB RID: 20411 RVA: 0x0023D824 File Offset: 0x0023BA24
	private e6t(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FBC RID: 20412 RVA: 0x0023D82C File Offset: 0x0023BA2C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FBD RID: 20413 RVA: 0x0023D830 File Offset: 0x0023BA30
	public e6t()
	{
	}

	// Token: 0x06004FBE RID: 20414 RVA: 0x0023D83C File Offset: 0x0023BA3C
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bpo.GetServiceOrThrow<d02>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			d60 addon = serviceOrThrow.aqw().GetAddon<d60>();
			if (addon != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
				{
					"patrolBot"
				})) as c5x;
				if (c5x == null || !c5x.h.b.aa().IsInCombat)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06004FBF RID: 20415 RVA: 0x0023D8C0 File Offset: 0x0023BAC0
	public string ji()
	{
		return "Sgs_TutorialPatrolBotHandledCondition";
	}
}
