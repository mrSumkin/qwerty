using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000DEB RID: 3563
[e79("Dc_MeetIris")]
public sealed class b65 : dgy
{
	// Token: 0x06004C0A RID: 19466 RVA: 0x00211A78 File Offset: 0x0020FC78
	public b65()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x.i.b.a(true, false);
				if (c5x.Area != null)
				{
					b65.b b = new b65.b();
					b.a = (new ar7(new Guid("59757827-3cfa-46b4-8b78-abdafd537b7d"), c5x.Area).ao() as c5x);
					if (b.a != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(b65.a.a.a));
						array[num] = dva;
						base.a(array);
						btm[] array2 = new btm[1];
						int num2 = 0;
						kw kw = new kw();
						kw.a(new bt4("dc-pp_m", new Vector3(19f, 39f, 0f)));
						kw.IsAsync = false;
						array2[num2] = kw;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(b.a));
						array3[num3] = dva2;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						egx egx = new egx();
						egx.a("Оу?!");
						array4[num4] = new ace(egx)
						{
							TargetRef = new ar7(b.a)
						};
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						egx egx2 = new egx();
						egx2.a("Своим электронным глазом я вижу неЧТО, похожее на НАРУШИТЕЛЯ!");
						array5[num5] = new ace(egx2)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(6.0))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						egx egx3 = new egx();
						egx3.a("Думаешь, что можешь прокрасться мимо меня и УБИТЬ Отца? УНИЧТОЖИТЬ Арку?");
						array6[num6] = new ace(egx3)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(6.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						egx egx4 = new egx();
						egx4.a("ХА-ХА-ХА-ХА!");
						array7[num7] = new ace(egx4)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						egx egx5 = new egx();
						egx5.a("Я НАСТОРОЖЕ. Я НА СТРАЖЕ. Я БЕЗЖАЛОСТНА.");
						array8[num8] = new ace(egx5)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(5.0))
						});
						btm[] array9 = new btm[1];
						int num9 = 0;
						egx egx6 = new egx();
						egx6.a("Я должна защищать. Все нарушители должны быть уничтожены.");
						array9[num9] = new ace(egx6)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array9);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(6.0))
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						egx egx7 = new egx();
						egx7.a("ХА-ХА-ХА-ХА!");
						array10[num10] = new ace(egx7)
						{
							TargetRef = new ar7(b.a),
							IsAsync = false
						};
						base.a(array10);
						btm[] array11 = new btm[1];
						int num11 = 0;
						kw kw2 = new kw();
						kw2.a(new bt4("dc-pp_m", c5x.Location));
						kw2.a(false);
						kw2.IsAsync = false;
						array11[num11] = kw2;
						base.a(array11);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array12 = new btm[1];
						int num12 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(b65.a.a.b));
						array12[num12] = dva3;
						base.a(array12);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						base.a(new btm[]
						{
							new ace(new bu0("cp_powerStation"))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000DEC RID: 3564
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004C0D RID: 19469 RVA: 0x00211FB4 File Offset: 0x002101B4
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.c);
			}
			return true;
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00211FD8 File Offset: 0x002101D8
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001EB4 RID: 7860
		public static readonly b65.a a = new b65.a();

		// Token: 0x04001EB5 RID: 7861
		public static Func<e6d, bool> b;

		// Token: 0x04001EB6 RID: 7862
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DED RID: 3565
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C10 RID: 19472 RVA: 0x00212004 File Offset: 0x00210204
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x04001EB7 RID: 7863
		public c5x a;
	}
}
