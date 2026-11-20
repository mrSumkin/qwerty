using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Common.Conditions;

// Token: 0x02002129 RID: 8489
[bmq("1.1.2.2_ReplaceHiddenCaveDoors", "1.1.2.2", "rc1,cv21,rkl2,lux-c5", false)]
public sealed class bj1 : fg
{
	// Token: 0x0600C89E RID: 51358 RVA: 0x0046C174 File Offset: 0x0046A374
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = null;
			if (A_1.y8() == "rc1")
			{
				c5x = (new ar7(new Guid("3cf299a5-1225-4dde-aa92-fb27cdf96483"), A_1.n(A_1.y8())).ao() as c5x);
			}
			else if (A_1.y8() == "lux-c5")
			{
				c5x = (new ar7(new Guid("52d06390-bc20-4923-8ed7-ec71354c8639"), A_1.n(A_1.y8())).ao() as c5x);
			}
			else if (A_1.y8() == "cv21")
			{
				c5x = (new ar7(new Guid("75bf0be0-4cf2-4cbd-8b22-ae9f8daef48e"), A_1.n(A_1.y8())).ao() as c5x);
			}
			else if (A_1.y8() == "rkl2")
			{
				c5x = (new ar7(new Guid("7b784568-3449-4f5e-8439-9de9eb0c274a"), A_1.n(A_1.y8())).ao() as c5x);
			}
			string str = "X";
			if (c5x != null)
			{
				cd0 aspect = c5x.GetAspect<cd0>();
				bim aspect2 = c5x.GetAspect<bim>();
				if (aspect != null && aspect2 != null)
				{
					aspect.a = "Walls\\CaveLuxHiddenDoorAnim";
					if (aspect2.t().Contains(HorizontalDirection.South) && !aspect2.t().Contains(HorizontalDirection.North))
					{
						aspect2.t().Add(HorizontalDirection.North);
						aspect.b.Y = 0;
						c5x.Size = new Vector3(c5x.Size.X + 1f, c5x.Size.Y, c5x.Size.Z);
					}
					else if (aspect2.t().Contains(HorizontalDirection.East) && !aspect2.t().Contains(HorizontalDirection.West))
					{
						aspect2.t().Add(HorizontalDirection.West);
						aspect.b.Y = 1;
						c5x.Size = new Vector3(c5x.Size.X, c5x.Size.Y + 1f, c5x.Size.Z);
						str = "Y";
					}
					foreach (cze cze in aspect2.s())
					{
						if (cze is e68 || cze is be6)
						{
							aspect2.s().Remove(cze);
							break;
						}
					}
					if (!Enumerable.Any<a2i>(Enumerable.OfType<a2i>(aspect2.s())))
					{
						aspect2.s().Add(new a2i());
					}
				}
				c5x.q("Cave Door");
				buf aspect3 = new buf(c5x);
				c5x.SetAspect<buf>(aspect3);
				if (A_1.y8() == "rc1")
				{
					c5x.Location = new Vector3(33f, 8f, 0f);
				}
				else if (A_1.y8() == "lux-c5")
				{
					c5x.Location = new Vector3(21f, 7f, 0f);
				}
				else if (A_1.y8() == "rkl2")
				{
					c5x.Location = new Vector3(16f, 5f, 0f);
				}
				else if (A_1.y8() == "cv21")
				{
					c5x.Location = new Vector3(2f, 15f, 0f);
				}
				c5x.TileFormationModifiers.c(new byte[]
				{
					0,
					1,
					2
				});
				c5x.ah();
				csi.a(c5x);
				b4h aspect4 = c5x.GetAspect<b4h>();
				if (aspect4 != null)
				{
					aspect4.b(false);
					if (aspect4.j())
					{
						ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
						if (ak == null)
						{
							goto IL_5EC;
						}
						using (List<b0b>.Enumerator enumerator2 = Enumerable.ToList<b0b>(ak.Entities).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								b0b b0b = enumerator2.Current;
								c5x c5x2 = (c5x)b0b;
								if (c5x2.o.b != null && c5x2.o.b.a == "Walls\\CaveLuxHiddenDoor")
								{
									c5x2.w();
									c5x2.an();
									break;
								}
							}
							goto IL_5EC;
						}
					}
					c5x c5x3 = vq.a("Door\\SecretCaveDoor" + str, A_1, new bt4(A_1.y8(), c5x.Location), false);
					if (c5x3 != null)
					{
						c5x3.RemoveAspect<bim>();
						c5x3.RemoveAspect<buf>();
						List<cze> list = aspect4.n();
						uk uk = new uk();
						uk.a(new Guid?(c5x3.qe()));
						list.Add(uk);
						csi.a(c5x3);
					}
					if (!A_0.r().GetPrimitivePropertyValue<bool>("rathound_king_secret_passage_reveal", new bool?(false)).Value && (A_1.y8() == "rkl2" || A_1.y8() == "cv21"))
					{
						if (!Enumerable.Any<c4f>(Enumerable.OfType<c4f>(aspect4.n())))
						{
							c4f c4f = new c4f();
							c4f.Properties["rathound_king_secret_passage_reveal"] = true;
							aspect4.n().Add(c4f);
						}
						if (aspect4.q() == null)
						{
							bj5 bj = new bj5();
							bj.a(CompositeConditionOperation.Or);
							List<dth> list2 = bj.b();
							er1 er = new er1();
							er.b("rathound_king_secret_passage_reveal");
							er.a(true);
							list2.Add(er);
							if (A_1.y8() == "rkl2")
							{
								List<dth> list3 = bj.b();
								d44 d = new d44();
								d.a(10);
								list3.Add(d);
							}
							else
							{
								List<dth> list4 = bj.b();
								d44 d2 = new d44();
								d2.a(15);
								list4.Add(d2);
							}
							aspect4.a(bj);
						}
					}
				}
				IL_5EC:
				foreach (ak1 ak2 in c5x.l)
				{
					foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.Entities))
					{
						csi.a((c5x)b0b2);
					}
					ak2.d();
				}
			}
			c5x c5x4 = new ar7(new Guid("c3aa77ff-8e3b-4e55-bcd5-6ce3dab10f06"), A_1.n("rc1")).ao() as c5x;
			if (c5x4 != null)
			{
				c5x4.Location = new Vector3(32.4f, 9.4f, 0f);
				c5x4.ah();
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
