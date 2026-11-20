using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules;

// Token: 0x020008F1 RID: 2289
[eiz("RNDDUPITICE")]
[Serializable]
public sealed class de3 : bdw, ISerializable
{
	// Token: 0x060038B1 RID: 14513 RVA: 0x00150188 File Offset: 0x0014E388
	private de3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x00150190 File Offset: 0x0014E390
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x00150194 File Offset: 0x0014E394
	public de3()
	{
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x001501A0 File Offset: 0x0014E3A0
	public void av(c1a A_0, cyt A_1)
	{
		List<int> classPropertyValue = A_1.r().GetClassPropertyValue<List<int>>("frag_dun_up_it_coldLevels");
		if (classPropertyValue == null || Enumerable.Count<int>(classPropertyValue) < 3)
		{
			if (A_1.ae() > GameDifficulty.Hard)
			{
				List<int> value = new List<int>
				{
					2,
					3,
					3,
					4
				};
				A_1.r()["frag_dun_up_it_coldLevels"] = value;
			}
			else
			{
				List<int> value2 = new List<int>
				{
					1,
					2,
					2,
					3
				};
				A_1.r()["frag_dun_up_it_coldLevels"] = value2;
			}
		}
		d60 d = A_0.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"dun_up_it_shouldFreeze"
			});
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null)
				{
					amc b = c5x.h.b;
					if (b != null && !b.aa().IsInCombat)
					{
						a2 a_ = Enumerable.FirstOrDefault<a2>(b.aa().StatusEffects.Get<a2>());
						b.u();
						b.aa().StatusEffects.d(a_);
						b.aa().StatusEffects.a(new a2(0, new double?(co4.b)), false, false, false);
						awq.e(b);
						awq.b(b);
						b.aa().PersonalAttitudes.Clear();
						c5x.d();
						a3f aspect = c5x.GetAspect<a3f>();
						if (aspect != null)
						{
							if (!b.aa().FactionId.Equals("neutral"))
							{
								aspect.a()["OldFaction"] = b.aa().FactionId;
							}
							else
							{
								aspect.a()["OldFaction"] = "monsters";
							}
							b.aa().FactionId = asp.a3;
						}
					}
				}
			}
			list.Clear();
			list = d.ab4(new string[]
			{
				"frozenPipe_btm"
			});
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				foreach (b0b b0b2 in list)
				{
					c5x a_2 = (c5x)b0b2;
					this.a(serviceOrThrow, a_2);
				}
				list.Clear();
				list = d.ab4(new string[]
				{
					"frozenPipe_up"
				});
				foreach (b0b b0b3 in list)
				{
					c5x a_3 = (c5x)b0b3;
					this.a(serviceOrThrow, a_3);
				}
			}
		}
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x001504E8 File Offset: 0x0014E6E8
	private void a(cnk A_0, c5x A_1)
	{
		string text = A_1.Area.y8();
		List<int> classPropertyValue = A_0.aqu().r().GetClassPropertyValue<List<int>>("frag_dun_up_it_coldLevels");
		if (classPropertyValue != null && classPropertyValue.Count >= 3)
		{
			int num = 0;
			if (text.Equals("dun_up_it2") || text.Equals("dun_up_it2_entrance") || text.Equals("dun_up_it2_sideRoom"))
			{
				num = 0;
			}
			else if (text.Equals("dun_up_it2_up") || text.Equals("dun_up_it2_sideRoomUp"))
			{
				num = 1;
			}
			else if (text.Equals("dun_up_it3") || text.Equals("dun_up_it3_northSideRoom") || text.Equals("dun_up_it3_westSideRoom"))
			{
				num = 2;
			}
			else if (text.Equals("dun_up_it3_up") || text.Equals("dun_up_it3_up1") || text.Equals("dun_up_it3_outside"))
			{
				num = 3;
			}
			else if (text.Equals("dun_up_it4") || text.Equals("dun_up_it4_up") || text.Equals("dun_up_it4_up1") || text.Equals("dun_up_it4_outside") || text.Equals("dun_up_it4_westSideRoom") || text.Equals("dun_up_it4_northSideRoom") || text.Equals("dun_up_it5") || text.Equals("dun_up_it5_up") || text.Equals("dun_up_it5_northSideRoom") || text.Equals("dun_up_it5_dom") || text.Equals("dun_up_it5_domOutside"))
			{
				num = 4;
			}
			float num2 = (cud.a(A_1.Location * 0.65f, 46, 0) + 1f) / 2f;
			num2 = MathHelper.Clamp(num2, 0f, 1f);
			if (A_1.o.b.b.Y % 2 == 0)
			{
				int y = this.a(d05.a(3f, d05.a(num2, (float)num, (float)num + 1f))) * 2;
				A_1.o.b.b.Y = y;
				return;
			}
			int y2 = this.a(d05.a(3f, d05.a(num2, (float)num, (float)num + 1f))) * 2 + 1;
			A_1.o.b.b.Y = y2;
		}
	}

	// Token: 0x060038B6 RID: 14518 RVA: 0x00150774 File Offset: 0x0014E974
	private int a(float A_0)
	{
		return (int)Math.Round((double)A_0, MidpointRounding.AwayFromZero);
	}
}
