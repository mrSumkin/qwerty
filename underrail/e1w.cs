using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x0200046B RID: 1131
public sealed class e1w : ak7
{
	// Token: 0x06001D57 RID: 7511 RVA: 0x000A2AA0 File Offset: 0x000A0CA0
	public e1w(string A_0) : base(A_0)
	{
		this.b = 3.0;
		this.c = 15;
		this.d = 350;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x000A2ACC File Offset: 0x000A0CCC
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject != null && this.Subject.y6()["lgSafePlaceLoc"] != null && base.acj(A_0, A_1);
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x000A2B0C File Offset: 0x000A0D0C
	public override float km(bool A_0)
	{
		return 1f;
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x000A2B14 File Offset: 0x000A0D14
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.a > 0.0)
		{
			this.a -= A_1;
			return ej1.a;
		}
		return base.aci(A_0, A_1);
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x000A2B44 File Offset: 0x000A0D44
	protected override ak1 afe(TimeSpan A_0, double A_1)
	{
		KeyValuePair<string, Point>? keyValuePair = this.Subject.y6()["lgSafePlaceLoc"] as KeyValuePair<string, Point>?;
		if (keyValuePair != null && this.Subject != null && this.Subject.a8() != null && this.Subject.a8().Area != null)
		{
			return this.Subject.a8().Area.a(keyValuePair.Value.Value);
		}
		return null;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x000A2BD4 File Offset: 0x000A0DD4
	protected override void afg(TimeSpan A_0, double A_1)
	{
		KeyValuePair<string, Point>? keyValuePair = this.Subject.y6()["lgSafePlaceLoc"] as KeyValuePair<string, Point>?;
		if (keyValuePair != null)
		{
			HashSet<string> hashSet = this.Subject.y6()["lgBlockedSafePlaces"] as HashSet<string>;
			if (hashSet == null)
			{
				hashSet = new HashSet<string>();
				this.Subject.y6()["lgBlockedSafePlaces"] = hashSet;
			}
			hashSet.Add(keyValuePair.Value.Key);
			this.Subject.y6()["lgSafePlaceLoc"] = null;
		}
		this.a = 300.0;
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x000A2C88 File Offset: 0x000A0E88
	protected override void aff(TimeSpan A_0, double A_1)
	{
		this.a = 300.0;
	}

	// Token: 0x04001038 RID: 4152
	private double a;
}
