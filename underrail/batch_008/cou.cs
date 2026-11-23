using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000468 RID: 1128
public sealed class cou : adt
{
	// Token: 0x06001D4C RID: 7500 RVA: 0x000A2710 File Offset: 0x000A0910
	public cou(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000A271C File Offset: 0x000A091C
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[cy1.g] = "hide";
		this.Subject.y6()["lgHideTimer"] = TimeSpan.FromSeconds(10.0);
		HashSet<string> hashSet = this.Subject.y6()["lgBlockedSafePlaces"] as HashSet<string>;
		if (hashSet != null)
		{
			hashSet.Clear();
		}
		base.h().aa().PersonalAttitudes.Clear();
		return ej1.b;
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x000A27A8 File Offset: 0x000A09A8
	public override bool acj(TimeSpan A_0, double A_1)
	{
		KeyValuePair<string, Point>? keyValuePair = this.Subject.y6()["lgSafePlaceLoc"] as KeyValuePair<string, Point>?;
		return keyValuePair != null && bnx.a(keyValuePair.Value.Value, this.Subject.a8().Location.a()) <= 2f;
	}
}
