using System;
using System.Runtime.Serialization;

// Token: 0x02001810 RID: 6160
[eiz("RLAGA")]
[Serializable]
public sealed class d3r : d64, ISerializable
{
	// Token: 0x060082F9 RID: 33529 RVA: 0x0036D928 File Offset: 0x0036BB28
	private d3r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060082FA RID: 33530 RVA: 0x0036D934 File Offset: 0x0036BB34
	public d3r()
	{
	}

	// Token: 0x060082FB RID: 33531 RVA: 0x0036D940 File Offset: 0x0036BB40
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.d() != null)
		{
			ckp ckp = ckf.a("rocketLauncher") as ckp;
			if (ckp != null)
			{
				ckp.a(base.c(), base.d(), cd, cd.CurrentBullet, null);
				return true;
			}
		}
		return false;
	}
}
