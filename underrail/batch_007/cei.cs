using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B78 RID: 2936
[eiz("FOSEFSJ")]
[Serializable]
public sealed class cei : cze, ISerializable
{
	// Token: 0x0600431B RID: 17179 RVA: 0x001A3854 File Offset: 0x001A1A54
	private cei(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("FOSEFSJ:A");
	}

	// Token: 0x0600431C RID: 17180 RVA: 0x001A3870 File Offset: 0x001A1A70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FOSEFSJ:A", this.a);
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x001A388C File Offset: 0x001A1A8C
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x001A3894 File Offset: 0x001A1A94
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x001A38A0 File Offset: 0x001A1AA0
	public cei()
	{
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x001A38AC File Offset: 0x001A1AAC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null)
		{
			aud aud = A_1.Area;
			bool flag = false;
			for (int i = 1; i <= 8; i++)
			{
				for (int j = 27; j <= 33; j++)
				{
					ak1 ak = aud.b(i, j);
					if (ak != null)
					{
						using (IEnumerator<b0b> enumerator = ak.c.Values.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (((c5x)enumerator.Current).y8() == "electrocutionEffect")
								{
									flag = true;
									break;
								}
							}
						}
					}
				}
			}
			if (flag != this.a)
			{
				for (int k = 1; k <= 8; k++)
				{
					for (int l = 27; l <= 33; l++)
					{
						ak1 ak2 = aud.b(k, l);
						if (ak2 != null)
						{
							if (this.a)
							{
								if (Enumerable.Any<c5x>(Enumerable.OfType<c5x>(ak2.c.Values), new Func<c5x, bool>(cei.a.a.a)))
								{
									c5x c5x = vq.a("wall\\ElectricCreepWall", aud.Zone, new bt4(aud.y8(), new Vector3((float)k, (float)l, 0f)), false);
									if (c5x != null)
									{
										ah7 ah = aud.Zone.i("Electricity");
										if (ah != null)
										{
											ah.g().be(c5x);
										}
										c5x.q("electrocutionEffect");
										c5x.IsGround = true;
										c5x.VisualPriority = 10;
										c5x.TileFormationModifiers.c();
										c5x.z();
										dm dm = new dm(c5x);
										dm.d().Add(new eyq());
										c5x.SetAspect<dm>(dm);
										a7c a7c = new a7c();
										a7c.Name = "electrocutionTrigger" + Guid.NewGuid().ToString();
										a7c.Layer = aju.x;
										a7c.h().Add(new n0());
										a7c.a().Add(new n0());
										a7c.Location = new Point(k, l);
										a7c.Size = new esj(1, 1);
										a7c.b(true);
										a7c.d(false);
										aud.b(a7c);
									}
								}
							}
							else
							{
								foreach (b0b b0b in Enumerable.ToList<b0b>(ak2.c.Values))
								{
									c5x c5x2 = (c5x)b0b;
									if (c5x2.y8() == "electrocutionEffect" && c5x2.h.b == null)
									{
										c5x2.w();
										c5x2.an();
									}
								}
								foreach (bqt bqt in Enumerable.ToList<bqt>(ak2.TriggerProxies))
								{
									if (bqt.Trigger != null && bqt.Trigger.Name != null && bqt.Trigger.Name.StartsWith("electrocutionTrigger"))
									{
										bqt.Trigger.o();
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001C35 RID: 7221
	private new bool a;

	// Token: 0x02000B79 RID: 2937
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004323 RID: 17187 RVA: 0x001A3C78 File Offset: 0x001A1E78
		internal bool a(c5x A_0)
		{
			return A_0.IsFloor && A_0.o.b != null && A_0.o.b.a == "Floor\\Grate-Gray";
		}

		// Token: 0x04001C36 RID: 7222
		public static readonly cei.a a = new cei.a();

		// Token: 0x04001C37 RID: 7223
		public static Func<c5x, bool> b;
	}
}
