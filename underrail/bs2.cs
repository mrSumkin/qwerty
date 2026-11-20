using System;
using System.Collections.Generic;

// Token: 0x02000341 RID: 833
[ajo("AdjRel")]
public sealed class bs2 : dj4
{
	// Token: 0x06001796 RID: 6038 RVA: 0x0007716C File Offset: 0x0007536C
	public override bool abf()
	{
		return false;
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x00077170 File Offset: 0x00075370
	public override bool abg()
	{
		return false;
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00077174 File Offset: 0x00075374
	public override bool abh()
	{
		return true;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x00077178 File Offset: 0x00075378
	public override void abi(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00077180 File Offset: 0x00075380
	public override void abj(cte A_0, b0b A_1)
	{
		bm6 bm = A_0 as bm6;
		c5x c5x = A_1 as c5x;
		if (bm != null && bm.a8() != null && bm.a8().h.b != null && c5x != null && c5x.h.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			efk efk = bm.a8().h.b.aa();
			efk efk2 = c5x.h.b.aa();
			if (efk2.HostilityBroadcastMode != c2n.a)
			{
				h? h = null;
				if (efk.FactionId == efk2.FactionId)
				{
					bqi bqi = serviceOrThrow.aqu().ac().abt(efk.FactionId);
					if (bqi != null)
					{
						h = new h?(bqi.g());
					}
				}
				else
				{
					cky cky = serviceOrThrow.aqu().ac().abu(efk.FactionId, efk2.FactionId);
					if (cky != null && cky.a == h.e)
					{
						h = cky.b;
					}
				}
				if (h != null)
				{
					foreach (KeyValuePair<string, h> keyValuePair in efk2.PersonalAttitudes)
					{
						if (keyValuePair.Value == h.a)
						{
							h? h2 = efk.f(keyValuePair.Key);
							if (h2 == null)
							{
								cky cky2 = serviceOrThrow.aqu().ac().abu(efk.FactionId, keyValuePair.Key);
								if (cky2 != null)
								{
									h2 = new h?(cky2.a);
								}
							}
							if (h2 == null || h2.Value > h.Value)
							{
								efk.a(keyValuePair.Key, h.Value);
								if (h.Value == h.a)
								{
									serviceOrThrow.aqu().ac().aby(efk.FactionId, keyValuePair.Key, efk.HostilityBroadcastMode, bm.a8().Zone);
								}
							}
						}
					}
				}
			}
		}
	}
}
