using System;
using System.Runtime.Serialization;

// Token: 0x0200172F RID: 5935
[eiz("CTDAA")]
[Serializable]
public sealed class dx3 : a6k
{
	// Token: 0x06008022 RID: 32802 RVA: 0x00361D50 File Offset: 0x0035FF50
	private dx3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008023 RID: 32803 RVA: 0x00361D5C File Offset: 0x0035FF5C
	public dx3()
	{
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x00361D64 File Offset: 0x0035FF64
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() != null && base.vg().q().Zone != null && base.vg().q().h.b != null)
		{
			if (base.vg().e() != null && base.vg().e().b9() is coh)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					ar7 ar = new ar7(new Guid("86a33617-b046-4818-93df-07ba6549cb7f"), base.vg().q().Area);
					string text;
					if (ar.ao() == null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_luben_escaped", new bool?(false)).Value)
					{
						text = "Здесь вы не ловите сигнала.";
					}
					else
					{
						string text2 = base.vg().q().Zone.y8().ToLowerInvariant();
						if (text2 != null)
						{
							switch (text2.Length)
							{
							case 3:
								switch (text2[2])
								{
								case '1':
									if (!(text2 == "cc1"))
									{
										goto IL_535;
									}
									break;
								case '2':
									if (!(text2 == "cc2"))
									{
										goto IL_535;
									}
									break;
								case '3':
									if (!(text2 == "cc3"))
									{
										goto IL_535;
									}
									text = "Сигнал исходит откуда-то с северо-запада.";
									goto IL_53B;
								case '4':
									if (!(text2 == "cc4"))
									{
										goto IL_535;
									}
									goto IL_514;
								case '5':
									if (!(text2 == "cc5"))
									{
										goto IL_535;
									}
									text = "Источник сигнала где-то рядом.";
									goto IL_53B;
								case '6':
									if (!(text2 == "cc6"))
									{
										goto IL_535;
									}
									text = "Сигнал исходит откуда-то с юго-запада.";
									goto IL_53B;
								case '7':
									if (!(text2 == "cc7"))
									{
										goto IL_535;
									}
									goto IL_514;
								case '8':
									if (!(text2 == "cc8"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								case '9':
									if (!(text2 == "cc9"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								default:
									goto IL_535;
								}
								text = "Сигнал исходит откуда-то с севера.";
								goto IL_53B;
								IL_514:
								text = "Сигнал исходит откуда-то с запада.";
								goto IL_53B;
							case 4:
								switch (text2[3])
								{
								case '0':
									if (!(text2 == "cc20"))
									{
										if (!(text2 == "cc10"))
										{
											goto IL_535;
										}
										goto IL_4E8;
									}
									break;
								case '1':
									if (!(text2 == "cc21"))
									{
										if (!(text2 == "cc11"))
										{
											goto IL_535;
										}
										goto IL_4E8;
									}
									break;
								case '2':
									if (!(text2 == "cc22"))
									{
										if (!(text2 == "cc12"))
										{
											goto IL_535;
										}
										goto IL_4E8;
									}
									break;
								case '3':
									if (!(text2 == "cc23"))
									{
										if (!(text2 == "cc13"))
										{
											goto IL_535;
										}
										goto IL_4E8;
									}
									break;
								case '4':
									if (!(text2 == "cc14"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								case '5':
									if (!(text2 == "cc15"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								case '6':
									if (!(text2 == "cc16"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								case '7':
									if (!(text2 == "cc17"))
									{
										goto IL_535;
									}
									goto IL_4E8;
								case '8':
									if (!(text2 == "cc18"))
									{
										goto IL_535;
									}
									break;
								case '9':
									if (!(text2 == "cc19"))
									{
										goto IL_535;
									}
									break;
								default:
									goto IL_535;
								}
								text = "Сигнал исходит откуда-то далеко снизу.";
								goto IL_53B;
							case 5:
								if (!(text2 == "cc15x"))
								{
									goto IL_535;
								}
								goto IL_4E8;
							case 6:
							{
								char c = text2[5];
								if (c != '1')
								{
									if (c != '2')
									{
										goto IL_535;
									}
									if (!(text2 == "cc_pz2"))
									{
										goto IL_535;
									}
								}
								else if (!(text2 == "cc_pz1"))
								{
									goto IL_535;
								}
								break;
							}
							case 7:
								if (!(text2 == "cc_dock"))
								{
									goto IL_535;
								}
								break;
							case 8:
								if (!(text2 == "cc_arena"))
								{
									goto IL_535;
								}
								goto IL_4E8;
							case 9:
								if (!(text2 == "cc_flcave"))
								{
									goto IL_535;
								}
								goto IL_4E8;
							case 10:
							{
								char c = text2[3];
								if (c != 'p')
								{
									if (c != 'u')
									{
										goto IL_535;
									}
									if (!(text2 == "cc_utility"))
									{
										goto IL_535;
									}
								}
								else if (!(text2 == "cc_passage"))
								{
									goto IL_535;
								}
								break;
							}
							case 11:
							case 13:
							case 14:
							case 15:
								goto IL_535;
							case 12:
								if (!(text2 == "cc_warehouse"))
								{
									goto IL_535;
								}
								text = "Сигнал исходит откуда-то с северо-востока.";
								goto IL_53B;
							case 16:
								if (!(text2 == "cc_enterGauntlet"))
								{
									goto IL_535;
								}
								goto IL_4E8;
							default:
								goto IL_535;
							}
							text = "Сигнал исходит откуда-то сверху.";
							goto IL_53B;
							IL_4E8:
							text = "Сигнал исходит откуда-то снизу.";
							goto IL_53B;
						}
						IL_535:
						text = "Здесь вы не ловите сигнала.";
						IL_53B:
						if (base.vg().q().Zone.y8().ToLowerInvariant() == "cc5" && ar.ao() != null)
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
						}
					}
					if (!string.IsNullOrEmpty(text))
					{
						bmj.a(base.vg().q(), new d53(text, adi.h, null, false));
						a7v.a(new h0(text, null));
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
