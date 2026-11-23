using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001025 RID: 4133
[eiz("KAFWRC")]
[Serializable]
public sealed class dtz : cze
{
	// Token: 0x06005546 RID: 21830 RVA: 0x0025AF60 File Offset: 0x00259160
	private dtz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("KAFWRC:C");
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x0025AF7C File Offset: 0x0025917C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("KAFWRC:C", this.a);
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06005548 RID: 21832 RVA: 0x0025AF98 File Offset: 0x00259198
	// (set) Token: 0x06005549 RID: 21833 RVA: 0x0025AFA0 File Offset: 0x002591A0
	public string RegCategory
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x0600554A RID: 21834 RVA: 0x0025AFAC File Offset: 0x002591AC
	public dtz()
	{
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x0025AFB4 File Offset: 0x002591B4
	public dtz(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x0025AFC4 File Offset: 0x002591C4
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
							c5x.h.b.ag().a().b().Clear();
							dtz dtz = Enumerable.First<dtz>(Enumerable.OfType<dtz>(c5x.h.b.ay()));
							if (dtz != null)
							{
								c5x.h.b.ay().Remove(dtz);
							}
							c5x.h.b.aa().a(null, null, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x040022BE RID: 8894
	private new string a;
}
