using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200102E RID: 4142
[eiz("BUAJ")]
[Serializable]
public sealed class a3q : cze, ISerializable
{
	// Token: 0x0600558A RID: 21898 RVA: 0x0025BC30 File Offset: 0x00259E30
	private a3q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("BUAJ:A");
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x0025BC4C File Offset: 0x00259E4C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BUAJ:A", this.a);
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x0025BC68 File Offset: 0x00259E68
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600558D RID: 21901 RVA: 0x0025BC70 File Offset: 0x00259E70
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600558E RID: 21902 RVA: 0x0025BC7C File Offset: 0x00259E7C
	public a3q()
	{
	}

	// Token: 0x0600558F RID: 21903 RVA: 0x0025BC84 File Offset: 0x00259E84
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			aud aud;
			if (!string.IsNullOrEmpty(this.a))
			{
				aud = A_1.Zone.n(this.a);
			}
			else
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				HashSet<c5x> hashSet = new HashSet<c5x>();
				for (int i = 0; i < aud.Size.c; i++)
				{
					for (int j = 0; j < aud.Size.c; j++)
					{
						ak1 ak = aud.b(i, j);
						if (ak != null && !ak.Formation.c(4L))
						{
							boj.a(aud, new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f), null, "ScorchGround", 1, double.MaxValue, null, null, null, null);
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
							{
								c5x c5x = b0b as c5x;
								if (c5x != null && c5x.h.b != null && !hashSet.Contains(c5x))
								{
									hashSet.Add(c5x);
									cwt cwt = new cwt();
									cwt.f.Add(new csk(DamageType.Heat, 10000));
									cwt.b = true;
									cwt.e = false;
									cwt.q = false;
									cwt.h = ImpactSpeed.High;
									cwt.k = "Взрыв";
									cwt.p = true;
									cwt.l = true;
									c5x.h.b.aa().Defense.a(cwt);
									cwt cwt2 = new cwt();
									cwt.f.Add(new csk(DamageType.Mechanical, 10000));
									cwt2.b = true;
									cwt2.e = false;
									cwt2.q = false;
									cwt2.h = ImpactSpeed.High;
									cwt2.p = true;
									cwt2.l = true;
									cwt2.k = "Взрыв";
									c5x.h.b.aa().Defense.a(cwt2);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x040022D1 RID: 8913
	private new string a;
}
