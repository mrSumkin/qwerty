using System;
using System.Runtime.Serialization;

// Token: 0x02001819 RID: 6169
[eiz("GLAGA")]
[Serializable]
public sealed class a8n : d64, ISerializable
{
	// Token: 0x0600834A RID: 33610 RVA: 0x0036E188 File Offset: 0x0036C388
	private a8n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600834B RID: 33611 RVA: 0x0036E194 File Offset: 0x0036C394
	public a8n()
	{
	}

	// Token: 0x0600834C RID: 33612 RVA: 0x0036E1A0 File Offset: 0x0036C3A0
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.d() != null)
		{
			du8 du = ckf.a("grenadeLauncher") as du8;
			if (du != null)
			{
				du.a(base.c(), base.d(), cd, cd.CurrentBullet, null);
				return true;
			}
		}
		return false;
	}
}
