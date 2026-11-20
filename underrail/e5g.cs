using System;
using System.Linq;

// Token: 0x02001010 RID: 4112
public static class e5g
{
	// Token: 0x060054D6 RID: 21718 RVA: 0x00257FAC File Offset: 0x002561AC
	public static void b(aud A_0)
	{
		if (bpo.GetServiceOrThrow<cnk>() != null)
		{
			foreach (ya ya in Enumerable.ToList<ya>(A_0.Triggers))
			{
				if (ya.Layer == 1)
				{
					if (ya is ee7)
					{
						ee7 ee = ya as ee7;
						if (ee != null)
						{
							ee.a().w();
							ee.a().an();
							ee.o();
						}
					}
					else if (ya is cos)
					{
						cos cos = ya as cos;
						if (cos != null)
						{
							cos.TrapEntity.w();
							cos.TrapEntity.an();
							cos.o();
						}
					}
					else if (ya is ed0)
					{
						ed0 ed = ya as ed0;
						if (ed != null)
						{
							if (ed.a().ao() != null)
							{
								ed.a().ao().a8().w();
								ed.a().ao().a8().an();
							}
							ed.o();
						}
					}
					else if (ya is sl)
					{
						sl sl = ya as sl;
						if (sl != null)
						{
							if (sl.a().ao() != null)
							{
								sl.a().ao().a8().w();
								sl.a().ao().a8().an();
							}
							sl.o();
						}
					}
					else if (ya is s8)
					{
						s8 s = ya as s8;
						if (s != null)
						{
							if (s.a().ao() != null)
							{
								s.a().ao().a8().w();
								s.a().ao().a8().an();
							}
							s.o();
						}
					}
				}
			}
		}
	}

	// Token: 0x060054D7 RID: 21719 RVA: 0x002581C8 File Offset: 0x002563C8
	public static void a(aud A_0)
	{
		foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.Entities))
		{
			c5x c5x = (c5x)b0b;
			if (c5x.Layer == aju.x)
			{
				if (c5x.GetAspect<a3f>() != null && c5x.GetAspect<a3f>().a().GetPrimitivePropertyValue<bool>("IsCorpse", new bool?(false)).Value)
				{
					c5x.an();
					c5x.w();
				}
				else if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
				{
					c5x.w();
					c5x.an();
				}
				else if (c5x.o.b != null && c5x.o.b.a == "Effects\\BloodPool")
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
