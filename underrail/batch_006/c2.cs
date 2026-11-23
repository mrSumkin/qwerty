using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200211E RID: 8478
[bmq("1.1.2.3_ReplaceDudeHouseCaveDoorAgain", "1.1.2.3", "lux-c5", false)]
public sealed class c2 : fg
{
	// Token: 0x0600C88B RID: 51339 RVA: 0x0046B460 File Offset: 0x00469660
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("52d06390-bc20-4923-8ed7-ec71354c8639"), A_1.n(A_1.y8())).ao() as c5x;
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
				c5x.Location = new Vector3(21f, 7f, 0f);
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
							goto IL_341;
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
							goto IL_341;
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
				}
				IL_341:
				foreach (ak1 ak2 in c5x.l)
				{
					foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.Entities))
					{
						csi.a((c5x)b0b2);
					}
					ak2.d();
				}
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
