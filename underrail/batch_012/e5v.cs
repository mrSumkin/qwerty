using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02000368 RID: 872
public static class e5v
{
	// Token: 0x06001862 RID: 6242 RVA: 0x0007B8DC File Offset: 0x00079ADC
	public static bool h(bm6 A_0)
	{
		EntityAspectReference<amc, amc> classPropertyValue = A_0.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			blk blk = new bzv(A_0.y6()).c(classPropertyValue.ao().a8().qe());
			if (blk != null && blk.b() && blk.a().f() == cem.d)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x0007B954 File Offset: 0x00079B54
	public static bool g(bm6 A_0)
	{
		EntityAspectReference<amc, amc> classPropertyValue = A_0.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			blk blk = new bzv(A_0.y6()).c(classPropertyValue.ao().a8().qe());
			if (blk != null && blk.b() && blk.a().f() == cem.d)
			{
				e5v.b(A_0.a8());
				bja bja = e5v.f(A_0);
				if (bja != null)
				{
					bt4 a_ = new bt4(classPropertyValue.ao().a8().Area.y8(), classPropertyValue.ao().a8().aj());
					bja.d(new asf(A_0.a8().qe(), a_));
				}
				cze cze = e5v.e(A_0);
				if (cze != null)
				{
					cze.ym(A_0.a8(), (bja != null) ? bja.a8() : null, null);
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x0007BA54 File Offset: 0x00079C54
	public static bja f(bm6 A_0)
	{
		EntityAspectReference<bja, bja> entityAspectReference = A_0.y6().GetClassPropertyValue<EntityAspectReference<bja, bja>>(ddq.ag);
		if (entityAspectReference == null || entityAspectReference.ao() == null)
		{
			if (A_0.a8() != null && A_0.a8().Zone != null)
			{
				string classPropertyValue = A_0.y6().GetClassPropertyValue<string>(ddq.al);
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					d60 d = A_0.a8().Zone.a();
					if (d != null)
					{
						c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
						{
							classPropertyValue
						})) as c5x;
						if (c5x != null)
						{
							entityAspectReference = new EntityAspectReference<bja, bja>(c5x.Area, c5x.qe());
							A_0.y6()[ddq.ag] = entityAspectReference;
						}
					}
				}
			}
			if (entityAspectReference == null || entityAspectReference.ao() == null)
			{
				Guid? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<Guid>(ddq.ae, null);
				if (primitivePropertyValue != null)
				{
					string classPropertyValue2 = A_0.y6().GetClassPropertyValue<string>(ddq.af);
					aud a_;
					if (!string.IsNullOrEmpty(classPropertyValue2))
					{
						a_ = A_0.a8().Zone.n(classPropertyValue2);
					}
					else
					{
						a_ = A_0.a8().Area;
					}
					entityAspectReference = new EntityAspectReference<bja, bja>(a_, primitivePropertyValue.Value);
					A_0.y6()[ddq.ag] = entityAspectReference;
				}
			}
		}
		if (entityAspectReference != null)
		{
			return entityAspectReference.ao();
		}
		return null;
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x0007BBC0 File Offset: 0x00079DC0
	public static cze e(bm6 A_0)
	{
		return A_0.y6().GetClassPropertyValue<cze>(ddq.ah);
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x0007BBD4 File Offset: 0x00079DD4
	public static bool? d(bm6 A_0)
	{
		EntityAspectReference<amc, amc> classPropertyValue = A_0.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			blk blk = new bzv(A_0.y6()).c(classPropertyValue.ao().a8().qe());
			if (blk != null && blk.b() && blk.a().f() == cem.d)
			{
				HorizontalDirection horizontalDirection;
				HorizontalDirection horizontalDirection2;
				e5v.a(A_0.y6().GetClassPropertyValue<string>(ddq.c), out horizontalDirection, out horizontalDirection2);
				HorizontalDirection horizontalDirection3 = bnx.a(A_0.a8().Location, classPropertyValue.ao().a8().Location);
				if (horizontalDirection3 >= horizontalDirection && horizontalDirection3 <= horizontalDirection2)
				{
					A_0.a8().VisualDirection = horizontalDirection3;
					return new bool?(true);
				}
			}
			return new bool?(false);
		}
		return null;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x0007BCB8 File Offset: 0x00079EB8
	public static void d(c5x A_0)
	{
		Color? c = A_0.p.b.a[e5v.a(A_0)].c;
		Color b = new Color(25, 225, 25);
		if (c != b)
		{
			A_0.c().a("camera", "CameraReset", 1f, c9z.a, false, false);
		}
		A_0.p.b.a[e5v.a(A_0)].c = new Color?(new Color(25, 225, 25));
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x0007BD6C File Offset: 0x00079F6C
	public static void c(c5x A_0)
	{
		if (A_0.p.b.a[e5v.a(A_0)].c != Color.Orange)
		{
			A_0.c().a("camera", "CameraWarning", 1f, c9z.a, false, false);
		}
		A_0.p.b.a[e5v.a(A_0)].c = new Color?(Color.Orange);
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x0007BE0C File Offset: 0x0007A00C
	public static void b(c5x A_0)
	{
		if (A_0.p.b.a[e5v.a(A_0)].c != Color.Red)
		{
			A_0.c().a("camera", "CameraAlert", 1f, c9z.a, false, false);
		}
		A_0.p.b.a[e5v.a(A_0)].c = new Color?(Color.Red);
		EntityAspectReference<amc, amc> classPropertyValue = A_0.t.b.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
		if (A_0.h.b != null && classPropertyValue != null && classPropertyValue.ao() != null && classPropertyValue.ao().a8() != null && classPropertyValue.ao().a8().Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().ac().aby(classPropertyValue.ao().aa().FactionId, A_0.h.b.aa().FactionId, A_0.h.b.aa().HostilityBroadcastMode, classPropertyValue.ao().a8().Zone);
			}
		}
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x0007BF78 File Offset: 0x0007A178
	public static void c(bm6 A_0)
	{
		e5v.d(A_0.a8());
		if (A_0.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.b, null) != null)
		{
			HorizontalDirection horizontalDirection;
			HorizontalDirection horizontalDirection2;
			e5v.a(A_0.y6().GetClassPropertyValue<string>(ddq.c), out horizontalDirection, out horizontalDirection2);
			int num = A_0.y6().GetPrimitivePropertyValue<int>(ddq.d, new int?(1)).Value;
			HorizontalDirection horizontalDirection3 = A_0.a8().VisualDirection;
			if (horizontalDirection2 == horizontalDirection && horizontalDirection3 == horizontalDirection2)
			{
				num = 0;
			}
			else if (horizontalDirection3 >= horizontalDirection2)
			{
				num = -1;
			}
			else if (horizontalDirection3 <= horizontalDirection)
			{
				num = 1;
			}
			A_0.a8().VisualDirection = horizontalDirection3 + num;
			A_0.y6()[ddq.d] = num;
		}
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x0007C058 File Offset: 0x0007A258
	public static bool b(bm6 A_0)
	{
		bzv bzv = new bzv(A_0.y6());
		EntityAspectReference<amc, amc> entityAspectReference = null;
		foreach (blk blk in bzv.b())
		{
			if (blk.e() != null && blk.b())
			{
				h h = blk.f();
				if (h != global::h.a && A_0.a8().h.b != null)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && A_0.a8().h.b.aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.a)
					{
						h = global::h.a;
					}
				}
				if (h == global::h.a || e5v.a(A_0, blk.e()))
				{
					Vector2 a_ = A_0.a8().aj().b();
					Vector2 vector = blk.e().a8().aj().b();
					if (bnx.a(a_, A_0.a8().VisualDirection, vector) < 50.0 || a_.a() == vector.a())
					{
						entityAspectReference = blk.d();
						break;
					}
				}
			}
		}
		if (entityAspectReference != null)
		{
			e5v.c(A_0.a8());
			A_0.y6()[ddq.f] = entityAspectReference;
			return true;
		}
		return false;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
	public static bool a(bm6 A_0, c5x A_1)
	{
		if (A_0 != null && A_0.a8() != null && A_1 != null)
		{
			blk blk = new bzv(A_0.y6()).c(A_1.qe());
			if (blk != null && blk.e() != null && blk.b())
			{
				Vector2 a_ = A_0.a8().aj().b();
				Vector2 vector = A_1.aj().b();
				if (bnx.a(a_, A_0.a8().VisualDirection, vector) < 50.0 || a_.a() == vector.a())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x0007C2A8 File Offset: 0x0007A4A8
	public static void a(bm6 A_0)
	{
		A_0.y6().RemoveProperty(ddq.f);
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x0007C2BC File Offset: 0x0007A4BC
	public static void a(string A_0, out HorizontalDirection A_1, out HorizontalDirection A_2)
	{
		string text = (A_0 ?? "").ToLowerInvariant();
		if (text != null)
		{
			switch (text.Length)
			{
			case 1:
			{
				char c = text[0];
				if (c == 'e')
				{
					A_1 = HorizontalDirection.South;
					A_2 = HorizontalDirection.West;
					return;
				}
				switch (c)
				{
				case 's':
					A_1 = HorizontalDirection.East;
					A_2 = HorizontalDirection.South;
					return;
				case 'w':
					A_1 = HorizontalDirection.North;
					A_2 = HorizontalDirection.East;
					return;
				case 'x':
					A_1 = HorizontalDirection.East;
					A_2 = HorizontalDirection.West;
					return;
				case 'y':
					A_1 = HorizontalDirection.North;
					A_2 = HorizontalDirection.South;
					return;
				}
				break;
			}
			case 2:
			{
				char c = text[1];
				if (c <= 'n')
				{
					if (c != 'e')
					{
						if (c == 'n')
						{
							if (text == "xn")
							{
								A_1 = HorizontalDirection.North;
								A_2 = HorizontalDirection.North;
								return;
							}
						}
					}
					else if (text == "xe")
					{
						A_1 = HorizontalDirection.East;
						A_2 = HorizontalDirection.East;
						return;
					}
				}
				else if (c != 's')
				{
					if (c == 'w')
					{
						if (text == "xw")
						{
							A_1 = HorizontalDirection.West;
							A_2 = HorizontalDirection.West;
							return;
						}
					}
				}
				else if (text == "xs")
				{
					A_1 = HorizontalDirection.South;
					A_2 = HorizontalDirection.South;
					return;
				}
				break;
			}
			case 3:
			{
				char c = text[1];
				if (c != 'n')
				{
					if (c == 's')
					{
						if (text == "xse")
						{
							A_1 = HorizontalDirection.Southeast;
							A_2 = HorizontalDirection.Southeast;
							return;
						}
						if (text == "xsw")
						{
							A_1 = HorizontalDirection.Southwest;
							A_2 = HorizontalDirection.Southwest;
							return;
						}
					}
				}
				else
				{
					if (text == "xne")
					{
						A_1 = HorizontalDirection.Northeast;
						A_2 = HorizontalDirection.Northeast;
						return;
					}
					if (text == "xnw")
					{
						A_1 = HorizontalDirection.Northwest;
						A_2 = HorizontalDirection.Northwest;
						return;
					}
				}
				break;
			}
			}
		}
		A_1 = HorizontalDirection.North;
		A_2 = HorizontalDirection.West;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x0007C494 File Offset: 0x0007A694
	private static bool a(bm6 A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null && A_1.a8().IsPlayer && A_1.a8().i.b != null)
		{
			if (A_1.a8().i.b.a(m7.m | m7.n).Count > 0 && A_1.a8().i.b.a() != null)
			{
				c5x c5x = A_1.a8().i.b.a().fm() as c5x;
				if (c5x != null)
				{
					c3g aspect = c5x.GetAspect<c3g>();
					if (aspect != null && !aspect.a(A_1.aa()))
					{
						return true;
					}
				}
			}
			if (A_1.a8().i.b.a(m7.l).Count > 0)
			{
				ZoneControlLevel zoneControlLevel;
				if (!A_1.aa().Passive)
				{
					zoneControlLevel = eir.a(A_0.a8().Zone, A_0.a8().h.b.aa().FactionId);
				}
				else
				{
					zoneControlLevel = ZoneControlLevel.Uncontrolled;
				}
				if (zoneControlLevel != ZoneControlLevel.Uncontrolled)
				{
					return true;
				}
			}
			HashSet<bqt> hashSet = new HashSet<bqt>();
			foreach (ak1 ak in A_1.a8().l)
			{
				foreach (bqt bqt in ak.TriggerProxies)
				{
					hashSet.Add(bqt);
				}
			}
			foreach (bqt bqt2 in hashSet)
			{
				a1w a1w = bqt2.Trigger as a1w;
				if (a1w != null && a1w.b().Contains(A_1.aa().FactionId) && (a1w.a().Contains(A_0.a8().h.b.aa().FactionId) || a1w.d().Contains(A_0.a8().qe())) && (a1w.g() == null || a1w.g().jh(a1w)))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0007C74C File Offset: 0x0007A94C
	private static int a(c5x A_0)
	{
		if (A_0 != null && A_0.p.b != null && (A_0.p.b.a[0].a == "Objects\\Devices\\BACamera" || A_0.p.b.a[0].a == "Objects\\Devices\\Camera2"))
		{
			return 1;
		}
		return 2;
	}
}
