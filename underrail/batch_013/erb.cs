using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000FED RID: 4077
public static class erb
{
	// Token: 0x060053F9 RID: 21497 RVA: 0x00251D6C File Offset: 0x0024FF6C
	public static void a(cyt A_0, c1a A_1, string A_2, csd A_3)
	{
		if (A_3 != null && A_3.Area != null)
		{
			c1a a_ = c1a.a(Path.Combine(d5x.o(), A_2) + ".uz");
			acu.a(a_);
			erb.a(a_, A_3.Area, A_3.Location, A_3.Name + "Dump");
			erb.b(a_, A_3);
		}
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x00251DD4 File Offset: 0x0024FFD4
	public static void a(string A_0, csd A_1)
	{
		if (A_1 != null && A_1.Area != null)
		{
			erb.a(c1a.a(Path.Combine(d5x.o(), A_0) + ".uz"), A_1);
		}
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x00251E0C File Offset: 0x0025000C
	private static void b(c1a A_0, csd A_1)
	{
		c1a c1a = A_1.Area.Zone;
		new List<ah7>();
		foreach (ah7 a_ in Enumerable.ToList<ah7>(A_0.LanternDefinitions))
		{
			A_0.b(a_);
		}
		foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
		{
			A_0.b(csd);
			csd.Location += A_1.Location;
			csd.AreaName = A_1.Area.y8();
			csd.Layer = 1;
			c1a.a(csd);
		}
		aud aud = Enumerable.First<aud>(A_0.Areas);
		string text = A_1.Name + "_" + Guid.NewGuid().ToString();
		erb.a item = new erb.a(text);
		foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
		{
			b0b.an();
			b0b.Layer = 1;
			Vector3 a_2;
			if (A_1.Location != Vector3.Zero)
			{
				a_2 = new Vector3(b0b.Location.X + A_1.Location.X, b0b.Location.Y + A_1.Location.Y, b0b.Location.Z);
			}
			else
			{
				a_2 = b0b.Location;
			}
			b0b.Location = a_2;
			A_1.Area.a(b0b);
			if (A_1.Area.Initialized)
			{
				b0b.bc(true);
			}
			c5x c5x = b0b as c5x;
			c5x.b("BoatPart_" + A_1.Name);
			c5x.b("BoatPart_" + text);
			eyo eyo = new eyo(c5x);
			eyo.d().Add(item);
			c5x.SetAspect<eyo>(eyo);
		}
		foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
		{
			ya.o();
			ya.Layer = 1;
			if (A_1.Location != Vector3.Zero)
			{
				ya.Location = d05.a(ya.Location, A_1.Location.a(), false);
			}
			l2 l = ya as l2;
			if (l != null)
			{
				l.jl(A_1.Area);
			}
			A_1.Area.b(ya);
		}
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x0025216C File Offset: 0x0025036C
	private static void a(c1a A_0, csd A_1)
	{
		aud aud = Enumerable.First<aud>(A_0.Areas);
		aud.l();
		HashSet<Point> hashSet = new HashSet<Point>();
		foreach (ya ya in aud.Triggers)
		{
			if (ya is et4)
			{
				for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
				{
					for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
					{
						hashSet.Add(new Point(i, j));
					}
				}
			}
		}
		Vector3 vector = A_1.Location;
		aud aud2 = A_1.Area;
		HashSet<ya> hashSet2 = new HashSet<ya>();
		for (int k = 0; k < aud.Size.d; k++)
		{
			for (int l = 0; l < aud.Size.c; l++)
			{
				Point a_ = new Point((int)(vector.X + (float)l), (int)(vector.Y + (float)k));
				ak1 ak = aud2.a(a_);
				if (ak != null)
				{
					bool flag = false;
					bool flag2 = true;
					ak1 ak2 = aud.b(l, k);
					if (ak2 != null && hashSet.Contains(ak2.Location))
					{
						flag2 = false;
					}
					if (flag2)
					{
						foreach (bqt bqt in ak.TriggerProxies)
						{
							if (bqt.Trigger != null && bqt.Trigger.Layer == 1)
							{
								hashSet2.Add(bqt.Trigger);
							}
						}
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.Layer == 1)
							{
								if (c5x.GetAspect<cx>() != null)
								{
									flag = true;
								}
								if (c5x.y8() == "Пси-двойник" && !c5x.IsPlayer)
								{
									c5x.w();
									c5x.an();
								}
								else
								{
									c5x.w();
									c5x.an();
									c5x.Location -= vector;
								}
							}
						}
					}
					if (flag)
					{
						foreach (b0b b0b2 in ak.Entities)
						{
							c5x c5x2 = (c5x)b0b2;
							if (!c5x2.IsFloor)
							{
								break;
							}
							if (c5x2.Layer == 0)
							{
								c5x2.ae = null;
							}
						}
					}
				}
			}
		}
		foreach (ya ya2 in hashSet2)
		{
			ya2.o();
		}
		foreach (csd csd in Enumerable.ToList<csd>(aud2.Zone.Waypoints))
		{
			if (csd.Layer == 1 && csd.Area == aud2 && csd.Location.X >= vector.X && csd.Location.Y >= vector.Y && csd.Location.X < vector.X + (float)aud.Size.c && csd.Location.Y < vector.Y + (float)aud.Size.d)
			{
				aud2.Zone.b(csd);
			}
		}
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x00252600 File Offset: 0x00250800
	private static void a(c1a A_0, aud A_1, Vector3 A_2, string A_3)
	{
		csd csd = A_1.Zone.g(A_3);
		if (csd != null && csd.Area == A_1)
		{
			int a_ = (int)csd.Location.X;
			int a_2 = (int)csd.Location.Y;
			aud aud = Enumerable.First<aud>(A_0.Areas);
			aud.l();
			HashSet<Point> hashSet = new HashSet<Point>();
			foreach (ya ya in aud.Triggers)
			{
				if (ya is et4)
				{
					for (int i = ya.Location.X; i < ya.Location.X + ya.Size.c; i++)
					{
						for (int j = ya.Location.Y; j < ya.Location.Y + ya.Size.d; j++)
						{
							hashSet.Add(new Point(i, j));
						}
					}
				}
			}
			for (int k = 0; k < aud.Size.d; k++)
			{
				for (int l = 0; l < aud.Size.c; l++)
				{
					ak1 ak = aud.b(l, k);
					bool flag = true;
					if (hashSet.Contains(ak.Location))
					{
						flag = false;
					}
					if (flag)
					{
						Point a_3 = new Point((int)(A_2.X + (float)l), (int)(A_2.Y + (float)k));
						ak1 ak2 = A_1.a(a_3);
						ak1 ak3 = A_1.b(a_, a_2);
						while (aw1.a(ak3 = A_1.b(a_, a_2), false, null, l9.b))
						{
							if (!erb.a(A_1, csd, ref a_, ref a_2))
							{
								return;
							}
						}
						if (ak2 != null && ak3 != null)
						{
							using (List<b0b>.Enumerator enumerator2 = Enumerable.ToList<b0b>(ak2.Entities).GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									b0b b0b = enumerator2.Current;
									c5x c5x = (c5x)b0b;
									if (c5x.Layer == aju.x && (c5x.h.b != null || c5x.s.b is c7j || c5x.s.b is wv) && !c5x.a(bp5.k + A_0.y8()))
									{
										c5x.Location = ak3.Location.a();
										c5x.ah();
									}
								}
								goto IL_295;
							}
							goto IL_284;
						}
						IL_295:
						if (!aw1.a(A_1.b(a_, a_2), false, null, l9.b))
						{
							goto IL_2AA;
						}
						IL_284:
						if (!erb.a(A_1, csd, ref a_, ref a_2))
						{
							return;
						}
						goto IL_295;
					}
					IL_2AA:;
				}
			}
		}
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x00252904 File Offset: 0x00250B04
	private static bool a(aud A_0, csd A_1, ref int A_2, ref int A_3)
	{
		int num = A_2 + 1;
		A_2 = num;
		if (num >= A_0.Size.c)
		{
			A_2 = (int)A_1.Location.X;
			num = A_3 + 1;
			A_3 = num;
			if (num >= A_0.Size.d)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x02000FEE RID: 4078
	[eiz("FLDBJ")]
	[Serializable]
	private sealed class a : cze, ISerializable
	{
		// Token: 0x060053FF RID: 21503 RVA: 0x00252954 File Offset: 0x00250B54
		private a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = A_0.GetString("FLDBJ:C");
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00252970 File Offset: 0x00250B70
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("FLDBJ:C", this.a);
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x0025298C File Offset: 0x00250B8C
		public a(string A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x002529A0 File Offset: 0x00250BA0
		public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("BoatFullyDiscovered_" + this.a, new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["BoatFullyDiscovered_" + this.a] = true;
				List<b0b> list = serviceOrThrow.aqw().GetAddon<d60>().ab4(new string[]
				{
					"BoatPart_" + this.a
				});
				if (list != null)
				{
					foreach (b0b b0b in list)
					{
						foreach (ak1 ak in b0b.l)
						{
							ak.a(dm9.a);
						}
					}
				}
			}
		}

		// Token: 0x0400224B RID: 8779
		private new string a;
	}
}
