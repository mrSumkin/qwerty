using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001013 RID: 4115
[eiz("SEFSJ")]
[Serializable]
public sealed class c48 : cze, ISerializable
{
	// Token: 0x060054E8 RID: 21736 RVA: 0x00259024 File Offset: 0x00257224
	private c48(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SEFSJ:A");
		this.b = (Point)A_0.GetValue("SEFSJ:S", typeof(Point));
		this.c = (Point)A_0.GetValue("SEFSJ:E", typeof(Point));
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x0025908C File Offset: 0x0025728C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEFSJ:A", this.a);
		info.AddValue("SEFSJ:S", this.b);
		info.AddValue("SEFSJ:E", this.c);
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x002590E0 File Offset: 0x002572E0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x002590E8 File Offset: 0x002572E8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x002590F4 File Offset: 0x002572F4
	public Point b()
	{
		return this.b;
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x002590FC File Offset: 0x002572FC
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x00259108 File Offset: 0x00257308
	public Point c()
	{
		return this.c;
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x00259110 File Offset: 0x00257310
	public void b(Point A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x0025911C File Offset: 0x0025731C
	public c48()
	{
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x00259128 File Offset: 0x00257328
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Area != null)
		{
			aud aud = A_1.Area;
			bool flag = false;
			for (int i = this.b.X; i <= this.c.X; i++)
			{
				for (int j = this.b.Y; j <= this.c.Y; j++)
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
				for (int k = this.b.X; k <= this.c.X; k++)
				{
					for (int l = this.b.Y; l <= this.c.Y; l++)
					{
						ak1 ak2 = aud.b(k, l);
						if (ak2 != null)
						{
							if (this.a)
							{
								if (Enumerable.Any<c5x>(Enumerable.OfType<c5x>(ak2.c.Values), new Func<c5x, bool>(c48.a.a.a)))
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
										c5x.TileFormationModifiers.s3(16);
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

	// Token: 0x0400228A RID: 8842
	private new bool a;

	// Token: 0x0400228B RID: 8843
	private Point b;

	// Token: 0x0400228C RID: 8844
	private Point c;

	// Token: 0x02001014 RID: 4116
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060054F4 RID: 21748 RVA: 0x00259550 File Offset: 0x00257750
		internal bool a(c5x A_0)
		{
			return A_0.IsFloor && A_0.GetAspect<cd0>() != null && (A_0.GetAspect<cd0>().a == "Floor\\Grate-Gray" || A_0.GetAspect<cd0>().a == "Floor\\Grate");
		}

		// Token: 0x0400228D RID: 8845
		public static readonly c48.a a = new c48.a();

		// Token: 0x0400228E RID: 8846
		public static Func<c5x, bool> b;
	}
}
