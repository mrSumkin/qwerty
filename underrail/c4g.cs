using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E38 RID: 3640
[e79("Lup_RigMutagen")]
public sealed class c4g : dgy
{
	// Token: 0x06004CAF RID: 19631 RVA: 0x002193B4 File Offset: 0x002175B4
	public c4g()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c4g.b b = new c4g.b();
			serviceOrThrow.aqu().r()["quest_prmutation_mutagenPlaced"] = true;
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			serviceOrThrow.aqu().ac();
			if (b.a != null)
			{
				b.c = (new ar7(new Guid("06b7c193-a583-4152-85c0-b9ae228d6413"), b.a.Area).ao() as c5x);
				b.b = (new ar7(new Guid("fc8181e1-7d78-45be-b19a-27a2f2ef182a"), b.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("cam1"));
				kw.a(false);
				kw.IsAsync = false;
				array[num] = kw;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				bb8 bb = new bb8();
				bb.a(new ar7(b.a));
				bb.a(CharacterState.Operating);
				bb.b(3);
				array2[num2] = bb;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("FragMineActivate"))
					{
						TargetRef = new ar7(b.b)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("CameraExplosion"))
					{
						TargetRef = new ar7(b.b)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("cam2"));
				kw2.a(false);
				kw2.IsAsync = false;
				array3[num3] = kw2;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (b.c != null)
				{
					b.c.a("BioagentExit");
					if (b.c.t.b != null)
					{
						b.c.t.b.y6()[ddq.bg] = true;
					}
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Что за фигня происходит?");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx2 = new egx();
					egx2.a("Сработала преждевременно?");
					array5[num5] = new ace(egx2)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx3 = new egx();
					egx3.a("Забудь, некогда сейчас раздумывать.");
					array6[num6] = new ace(egx3)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx4 = new egx();
					egx4.a("Выбирайся оттуда, и быстро.");
					array7[num7] = new ace(egx4)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx5 = new egx();
					egx5.a("Найдите другой выход, и что бы ни случилось - не вступайте в контакт с газом.");
					array8[num8] = new ace(egx5)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx6 = new egx();
					egx6.a("Бегом!");
					array9[num9] = new ace(egx6)
					{
						TargetRef = new ar7(b.c)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				btm[] array10 = new btm[1];
				array10[0] = new dva(null, new Func<e6d, bool>(c4g.a.a.a), null, null, null);
				base.a(array10);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E39 RID: 3641
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004CB2 RID: 19634 RVA: 0x00219998 File Offset: 0x00217B98
		internal bool a(e6d A_0)
		{
			bpo.GetServiceOrThrow<cnk>().aqu().r()["loc_lup_freeDroneBase_gasStarted"] = true;
			bpo.GetServiceOrThrow<cnk>().aqu().b(new dxz());
			return true;
		}

		// Token: 0x04001F2A RID: 7978
		public static readonly c4g.a a = new c4g.a();

		// Token: 0x04001F2B RID: 7979
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E3A RID: 3642
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004CB4 RID: 19636 RVA: 0x002199E8 File Offset: 0x00217BE8
		internal bool b(e6d A_0)
		{
			if (this.b != null)
			{
				dxv aspect = this.b.GetAspect<dxv>();
				if (aspect != null)
				{
					aspect.a(true);
				}
			}
			return true;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00219A1C File Offset: 0x00217C1C
		internal bool a(e6d A_0)
		{
			aw1.b(this.a, this.c, false);
			aw1.b(this.c, this.a, false);
			return true;
		}

		// Token: 0x04001F2C RID: 7980
		public c5x a;

		// Token: 0x04001F2D RID: 7981
		public c5x b;

		// Token: 0x04001F2E RID: 7982
		public c5x c;
	}
}
