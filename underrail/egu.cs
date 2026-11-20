using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000AAF RID: 2735
[eiz("TCHUBV")]
[Serializable]
public sealed class egu : cze, ISerializable
{
	// Token: 0x06003FED RID: 16365 RVA: 0x00183F5C File Offset: 0x0018215C
	private egu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x00183F68 File Offset: 0x00182168
	public egu()
	{
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x00183F74 File Offset: 0x00182174
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		c5x c5x2 = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.t.b != null && c5x2 != null)
		{
			if (c5x.h.b.aa().FactionId == asp.ew)
			{
				d60 addon = c5x2.Zone.GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"beetleVent"
					});
					if (list.Count > 0)
					{
						for (int i = list.Count - 1; i >= 0; i--)
						{
							c5x c5x3 = list[i] as c5x;
							if (c5x3 == c5x2)
							{
								list.RemoveAt(i);
							}
							else
							{
								ak1 ak;
								if (c5x3.VisualDirection == HorizontalDirection.South)
								{
									ak = c5x3.Area.b((int)c5x3.Location.X, (int)c5x3.Location.Y + 1);
								}
								else
								{
									ak = c5x3.Area.b((int)c5x3.Location.X + 1, (int)c5x3.Location.Y);
								}
								if (ak == null || aw1.a(null, ak, false, null))
								{
									list.RemoveAt(i);
								}
							}
						}
					}
					if (list.Count > 0)
					{
						c5x c5x4 = list[cuo.a.Next(list.Count)] as c5x;
						ak1 ak2;
						if (c5x4.VisualDirection == HorizontalDirection.South)
						{
							ak2 = c5x4.Area.b((int)c5x4.Location.X, (int)c5x4.Location.Y + 1);
						}
						else
						{
							ak2 = c5x4.Area.b((int)c5x4.Location.X + 1, (int)c5x4.Location.Y);
						}
						if (ak2 != null)
						{
							a0l.a(c5x, ak2.Area, ak2.Location.a(), new HorizontalDirection?(c5x4.VisualDirection), true);
							c5x.h.b.aa().PersonalAttitudes.Clear();
							new bzv(c5x.t.b.y6()).e();
							bpo.GetServiceOrThrow<d02>().ahs(true, false);
							c5x.h.b.aa().Cooldowns.a(new cfd[]
							{
								new cfd("ventEscape", d0u.b * 2, false, true)
							});
							return;
						}
					}
				}
			}
			else
			{
				string a_ = "Это вентиляционное отверстие слишком мало, чтобы через него пролезть.";
				a7v.a(new v4(a_));
				bmj.a(c5x2, new d53(a_, adi.h, null, false));
			}
		}
	}
}
