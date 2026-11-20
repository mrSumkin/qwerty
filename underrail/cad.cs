using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001026 RID: 4134
[eiz("KACWRC")]
[Serializable]
public sealed class cad : cze
{
	// Token: 0x0600554D RID: 21837 RVA: 0x0025B114 File Offset: 0x00259314
	private cad(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("KACWRC:C");
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x0025B130 File Offset: 0x00259330
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("KACWRC:C", this.a);
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x0025B14C File Offset: 0x0025934C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005550 RID: 21840 RVA: 0x0025B154 File Offset: 0x00259354
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005551 RID: 21841 RVA: 0x0025B160 File Offset: 0x00259360
	public cad()
	{
	}

	// Token: 0x06005552 RID: 21842 RVA: 0x0025B168 File Offset: 0x00259368
	public cad(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005553 RID: 21843 RVA: 0x0025B17C File Offset: 0x0025937C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = cze.a(null, A_0, A_1, A_2);
		if (aud != null && aud.Zone != null)
		{
			d60 addon = aud.Zone.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					this.a
				});
				if (list != null && list.Count > 0)
				{
					foreach (b0b b0b in list)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && !c5x.h.b.aa().Dead)
						{
							c5x.h.b.aa().a(null, null, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x040022BF RID: 8895
	private new string a;
}
