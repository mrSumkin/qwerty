using System;
using System.Runtime.Serialization;

// Token: 0x02001734 RID: 5940
[eiz("ETN0")]
[Serializable]
public sealed class d83 : a6k
{
	// Token: 0x06008031 RID: 32817 RVA: 0x00362D54 File Offset: 0x00360F54
	private d83(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x00362D60 File Offset: 0x00360F60
	public d83()
	{
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x00362D6C File Offset: 0x00360F6C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null)
		{
			if (base.vg().e() != null && base.vg().e().b9() is coh)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					string text2;
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_sgsarlene_dead", new bool?(false)).Value)
					{
						string text = base.vg().q().Zone.y8();
						if (text != null)
						{
							int length = text.Length;
							if (length <= 15)
							{
								if (length != 14)
								{
									if (length == 15)
									{
										if (text == "CrossroadCaves2")
										{
											text2 = "Слабый сигнал исходит откуда-то с северо-запада и сверху.";
											goto IL_2A2;
										}
									}
								}
								else if (text == "CrossroadCaves")
								{
									text2 = "Слабый сигнал исходит откуда-то с запада и сверху.";
									goto IL_2A2;
								}
							}
							else
							{
								if (length == 19)
								{
									char c = text[18];
									switch (c)
									{
									case '1':
										if (!(text == "StationAlpha-Level1"))
										{
											goto IL_29C;
										}
										break;
									case '2':
										if (!(text == "StationAlpha-Level2"))
										{
											goto IL_29C;
										}
										break;
									case '3':
										if (!(text == "StationAlpha-Level3"))
										{
											goto IL_29C;
										}
										text2 = "Очень сильный сигнал исходит откуда-то поблизости.";
										goto IL_2A2;
									case '4':
										if (!(text == "StationAlpha-Level4"))
										{
											goto IL_29C;
										}
										goto IL_270;
									case '5':
										if (!(text == "StationAlpha-Level5"))
										{
											goto IL_29C;
										}
										goto IL_270;
									case '6':
										if (!(text == "StationAlpha-Level6"))
										{
											goto IL_29C;
										}
										goto IL_270;
									case '7':
										if (!(text == "StationAlpha-Level7"))
										{
											goto IL_29C;
										}
										goto IL_270;
									case '8':
										if (!(text == "StationAlpha-Level8"))
										{
											goto IL_29C;
										}
										goto IL_270;
									case '9':
										if (!(text == "StationAlpha-Level9"))
										{
											goto IL_29C;
										}
										goto IL_270;
									default:
										if (c != 'n')
										{
											goto IL_29C;
										}
										if (!(text == "LU-SouthGateStation"))
										{
											goto IL_29C;
										}
										break;
									}
									text2 = "Сильный сигнал исходит откуда-то снизу.";
									goto IL_2A2;
									IL_270:
									text2 = "Сильный сигнал исходит откуда-то сверху.";
									goto IL_2A2;
								}
								if (length == 21)
								{
									if (text == "LU-SouthGateStation-N")
									{
										text2 = "Слабый сигнал исходит откуда-то с юга и снизу.";
										goto IL_2A2;
									}
								}
							}
						}
						IL_29C:
						text2 = "Здесь вы не ловите сигнала.";
						IL_2A2:
						if (base.vg().q().Zone.y8() == "StationAlpha-Level3")
						{
							ar7 ar = new ar7(new Guid("83cd7a34-f8e8-461d-af96-e3ac9622b1bc"), base.vg().q().Area);
							if (ar.ao() != null)
							{
								b0b a_;
								dvv item = es2.a(base.vg().q(), ar.ao(), "psi", 0.5f, null, out a_, true, 0.5f);
								qy qy = new qy();
								qy.b(false);
								qy.c(false);
								qy.ad().Add(item);
								c7 c2 = new c7(a_, false, false, true, false);
								c2.a(true);
								qy.ad().Add(c2);
								base.vg().q().Zone.ActionManager.g9(qy, atp.a);
								dz6.a(qy);
								serviceOrThrow.aqu().r()["quest_trackerNecklace_arleneTracked"] = true;
							}
						}
					}
					else
					{
						text2 = "Здесь вы не ловите сигнала.";
					}
					if (!string.IsNullOrEmpty(text2))
					{
						bmj.a(base.vg().q(), new d53(text2, adi.h, null, false));
						a7v.a(new h0(text2, null));
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
