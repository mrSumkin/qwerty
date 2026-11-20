using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;
using Ouroboros.Playfield.Aspects;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200055D RID: 1373
internal sealed class d6f : cnk, z6, bu6, eil, abd, hs
{
	// Token: 0x06002332 RID: 9010 RVA: 0x000C12CC File Offset: 0x000BF4CC
	public Guid qe()
	{
		return new Guid("{BE60E511-6489-44e9-8361-7D25A366F7AA}");
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000C12D8 File Offset: 0x000BF4D8
	public string y8()
	{
		return "TimelapseManager";
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x000C12E0 File Offset: 0x000BF4E0
	public cyt aqu()
	{
		return this.b;
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x000C12E8 File Offset: 0x000BF4E8
	public void aqv(cyt A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x000C12F4 File Offset: 0x000BF4F4
	public c1a aqw()
	{
		return this.c;
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x000C12FC File Offset: 0x000BF4FC
	public void aqx(c1a A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x000C1308 File Offset: 0x000BF508
	public ps aqy()
	{
		return this.d;
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x000C1310 File Offset: 0x000BF510
	public ex7 aqz()
	{
		return this.e;
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x000C1318 File Offset: 0x000BF518
	public dse aq0()
	{
		if (this.f == null)
		{
			this.f = d6f.q();
		}
		return this.f;
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x000C1338 File Offset: 0x000BF538
	public ls aq1()
	{
		return this.g;
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x000C1340 File Offset: 0x000BF540
	public GameDifficulty aq2()
	{
		return this.ar2().EncounterDifficulty;
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x000C1350 File Offset: 0x000BF550
	public GameDifficulty aq3()
	{
		return this.ar2().PuzzleDifficulty;
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x000C1360 File Offset: 0x000BF560
	public Dictionary<string, dh2> aq4()
	{
		return this.h;
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x000C1368 File Offset: 0x000BF568
	public int aq5()
	{
		return this.j;
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x000C1370 File Offset: 0x000BF570
	public void aq6(int A_0)
	{
		this.j = d05.a(0, A_0, this.aq7());
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x000C1388 File Offset: 0x000BF588
	public int aq7()
	{
		return 4;
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x000C138C File Offset: 0x000BF58C
	public float aq8()
	{
		return this.k;
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x000C1394 File Offset: 0x000BF594
	public void aq9(float A_0)
	{
		this.ar1(A_0, true);
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x000C13A0 File Offset: 0x000BF5A0
	public d6f()
	{
		this.g();
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x000C13D0 File Offset: 0x000BF5D0
	public void a(ls A_0)
	{
		if (cxc.b())
		{
			A_0.g().a = DisplayResolution.r1280x800;
			A_0.g().b = OuroborosDisplayMode.BorderlessWindowed;
			A_0.b().b(UiSize.Small);
		}
		ls ls = this.g;
		this.g = A_0;
		if (this.g.b().q() == MainMenuTheme.HeavyDuty && !dk2.e())
		{
			this.g.b().a(MainMenuTheme.Default);
		}
		if (this.g.b().q() == MainMenuTheme.Expedition && !dk2.f())
		{
			this.g.b().a(MainMenuTheme.Default);
		}
		bool flag = false;
		if (!this.g.g().d)
		{
			this.ar1(1f, false);
		}
		if (ls == null || ls.g().a != this.g.g().a || ls.g().b != this.g.g().b || ls.g().c != this.g.g().c)
		{
			this.i();
			flag = true;
		}
		else if (ls == null || ls.b().m() != this.g.b().m() || ls.g().d != this.g.g().d || ls.b().d() != this.g.b().d())
		{
			flag = true;
		}
		else
		{
			string text;
			if (ls == null)
			{
				text = null;
			}
			else
			{
				a94 a = ls.c();
				text = ((a != null) ? a.a() : null);
			}
			if (text != this.g.c().a())
			{
				flag = true;
			}
			else
			{
				bool? flag2;
				if (ls == null)
				{
					flag2 = null;
				}
				else
				{
					cnt cnt = ls.g();
					flag2 = ((cnt != null) ? new bool?(cnt.g) : null);
				}
				bool? flag3 = flag2;
				bool flag4 = this.g.g().g;
				if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
				{
					flag = true;
				}
			}
		}
		aji.c(A_0.c().a());
		if (flag)
		{
			bl9.b();
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anc();
			}
		}
		this.h();
		bcm service2 = bpo.GetService<bcm>();
		if (service2 != null)
		{
			service2.aa3(this.g.g().b == OuroborosDisplayMode.Fullscreen && this.g.e().b());
			ci3 ci = service2.aau() as ci3;
			if (ci != null && ci.q() != null)
			{
				ci.q().a(this.g.e().f());
				ci.q().d.a(this.g.e().d());
			}
		}
		if (ls != null && ls.g().e != this.g.g().e)
		{
			cne service3 = bpo.GetService<cne>();
			if (this.g.g().e)
			{
				service3.u1();
				return;
			}
			service3.u2();
		}
	}

	// Token: 0x06002346 RID: 9030 RVA: 0x000C1750 File Offset: 0x000BF950
	public void ara()
	{
		ls a_ = ls.a();
		this.a(a_);
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x000C176C File Offset: 0x000BF96C
	public void arb(ls A_0)
	{
		string text = d5x.f();
		try
		{
			string directoryName = Path.GetDirectoryName(text);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			eoq.SerializeToBinaryFileCompressed<ls>(text, A_0, dds.a(), eh9.c, true);
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Не удалось сохранить файл конфигурации.", new object[0]);
		}
		this.a(A_0);
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x000C17E0 File Offset: 0x000BF9E0
	public void arc(ls A_0)
	{
		this.a(A_0);
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x000C17EC File Offset: 0x000BF9EC
	public void d1(e6d A_0)
	{
		if (this.d != null)
		{
			this.d.b(A_0);
		}
		am7 service = bpo.GetService<am7>();
		if (service != null)
		{
			string a_ = null;
			if (this.b != null && this.b.v() != null && this.b.v().b() != null && this.b.v().b().Area != null)
			{
				a_ = this.b.v().b().Area.CustomProperties.GetClassPropertyValue<string>("Music");
			}
			service.ai3(c2g.c, new bn3(a_, 1f, null, null));
			service.ai6();
		}
		if (this.b != null)
		{
			es6.a(this, A_0.a().ElapsedGameTime.TotalMilliseconds);
			if ((this.i += A_0.a().ElapsedGameTime.TotalMilliseconds) > 1000.0)
			{
				this.i = 0.0;
				for (int i = this.b.s().Count - 1; i >= 0; i--)
				{
					if (this.b.s()[i].a(this.b))
					{
						this.b.s().RemoveAt(i);
					}
				}
			}
		}
		e5f service2 = bpo.GetService<e5f>();
		if (service2 != null)
		{
			service2.asn(A_0);
		}
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x000C1990 File Offset: 0x000BFB90
	public ps ard()
	{
		if (this.d == null)
		{
			this.d = new dka();
		}
		return this.d;
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x000C19B0 File Offset: 0x000BFBB0
	public void are()
	{
		if (this.d != null)
		{
			this.d.ae();
			this.d = null;
		}
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x000C19D4 File Offset: 0x000BFBD4
	public void arf()
	{
		bl9.d();
		this.b = new cyt();
		this.p();
		this.b.a(new au2());
		this.b.v().Id = "player";
		this.b.v().FactionId = asp.a;
		this.b.v().AttributesBase = (d8o.b | d8o.c | d8o.d);
		this.b.v().BaseSightRange = 13f;
		this.b.v().k();
		this.b.v().SpecialAttacks.b(dgk.Get<eua>());
		this.b.v().SpecialAttacks.b(dgk.Get<c91>());
		this.b.v().SpecialAbilities.b(dgk.Get<e5b>());
		this.b.v().SpecialAbilities.b(dgk.Get<eag>());
		this.b.v().SpecialAbilities.b(dgk.Get<e7t>());
		if (this.b.v().Gear.l().Item == null)
		{
			this.b.v().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\ShirtAndPants")), true);
		}
		this.b.v().BaseMovementSpeed = aiy.d;
		bv9 a_ = new bv9(new c7g());
		dx9.a(ref a_);
		this.b.a(a_);
		this.b.a(new c2w("StationAlpha-Level3", "intropl"));
		d6f.m();
		this.e.a(this.b);
		cqh cqh = new cqh("messages\\tanner/dutyCallsSummon", "Добро пожаловать", new string[0]);
		cqh.Author = "Таннер";
		cqh.Portrait = "tanner";
		cqh.OnReadJobs.Add("RM_T1");
		this.b.w().Add(cqh);
		cqh cqh2 = new cqh("messages\\wayne/fixedYourDoor", "Ключ-карта", new string[0]);
		cqh2.Author = "Уэйн";
		cqh2.Portrait = "Wayne";
		this.b.w().Add(cqh2);
		a4i.a(this.b);
		this.e.atb("DutyCalls", false);
		this.b.a(new bau());
		this.b.m().a = new cl7();
		this.b.m().b = TimelapseTextFeeds.Combat;
		this.b.m().a.a = new Dictionary<Keys, List<av>>();
		this.b.m().a.a[Keys.None] = new List<av>
		{
			ecf.a(dgk.Get<eua>(), new dsx(), null),
			ecf.a(dgk.Get<c91>(), new dsx(), null),
			ecf.a(dgk.Get<e5b>(), new dsx(), null),
			ecf.a(dgk.Get<eag>(), new dsx(), null)
		};
		this.b.m().a.a[Keys.LeftShift] = new List<av>();
		this.b.m().a.a[Keys.LeftControl] = new List<av>();
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.ank();
		}
		bpo.GetServiceOrThrow<e5f>().asd();
		this.o();
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x000C1D78 File Offset: 0x000BFF78
	public void arg(string A_0, bool A_1 = false, bool A_2 = false)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			dux.a(LogSeverity.Error, "Название сохранения не должно быть нулём или пустым.", new object[0]);
		}
		try
		{
			if (!A_1)
			{
				bpo.GetServiceOrThrow<ps>().am1();
				this.arr(false);
			}
			d6f.k();
			string text = d5x.d(A_0);
			if (Directory.Exists(text))
			{
				if (A_2)
				{
					string text2 = d5x.e(A_0);
					if (Directory.Exists(text2))
					{
						cjf.a(text2);
						Directory.Delete(text2, true);
					}
					Directory.Move(text, text2);
				}
				else
				{
					cjf.a(text);
					Directory.Delete(text, true);
				}
			}
			if (bmg.a)
			{
				cjf.b(d5x.n(), text);
			}
			else
			{
				bmg.d(text);
			}
			this.b(text, A_1);
			this.a(text, A_1);
			this.b(text);
		}
		catch (Exception ex)
		{
			dux.a(ex, LogSeverity.Error, "Failed to save game '{0}'. Exception: {1}", new object[]
			{
				A_0,
				ex.ToString()
			});
			try
			{
				string text3 = d5x.e();
				if (Directory.Exists(text3))
				{
					string text4 = Path.Combine(text3, string.Format("SaveError-{0}.txt", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss")));
					string text5 = string.Format("Версия игры: {0}\r\nОшибка: {1}", dm9.d, ex.ToString());
					File.WriteAllText(text4, text5);
				}
			}
			catch
			{
			}
		}
		finally
		{
			if (!A_1)
			{
				this.s();
			}
			d6f.j();
		}
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x000C1F2C File Offset: 0x000C012C
	public bool arh()
	{
		return (this.c == null || !this.c.CustomProperties.GetPrimitivePropertyValue<bool>("SavingDisabled", new bool?(false)).Value) && (this.b != null && this.b.v() != null && !this.b.v().IsInCombat) && !dz6.e();
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x000C1FA8 File Offset: 0x000C01A8
	public void ari(string A_0, bool A_1)
	{
		bl9.d();
		Stopwatch stopwatch = Stopwatch.StartNew();
		if (string.IsNullOrEmpty(A_0))
		{
			dux.b(LogSeverity.Error, "Название сохранения не должно быть нулём или пустым.", new object[0]);
		}
		try
		{
			Trace.WriteLine("++ Начало загрузки игры...");
			string text = d5x.d(A_0);
			d6f.l();
			stopwatch.Stop();
			Trace.WriteLine("++ Current FS structure deleted: " + stopwatch.Elapsed.ToString());
			stopwatch.Reset();
			stopwatch.Start();
			if (!Directory.Exists(text))
			{
				dux.b(LogSeverity.Error, "Сохранение не найдено: '{0}'", new object[]
				{
					A_0
				});
			}
			else
			{
				string text2 = d5x.n();
				if (bmg.a)
				{
					cjf.b(text, text2);
				}
				else
				{
					bmg.c(text);
				}
				stopwatch.Stop();
				Trace.WriteLine("++ Сохранение скопировано: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				stopwatch.Start();
				if (bmg.a)
				{
					string a_ = Path.Combine(text2, "global.dat");
					this.b = cyt.a(a_);
				}
				else
				{
					string a_2 = Path.Combine(text, "global.dat");
					this.b = cyt.a(a_2);
				}
				stopwatch.Stop();
				Trace.WriteLine("++ Binary loading complete: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				stopwatch.Start();
				foreach (cka cka in this.b.b().a().Values)
				{
					if (!cka.a() && cka.h() != null)
					{
						bm6 aspect = cka.h().GetAspect<bm6>();
						if (aspect != null)
						{
							anp classPropertyValue = aspect.y6().GetClassPropertyValue<anp>(ddq.a1);
							if (classPropertyValue != null)
							{
								aspect.y6()[ddq.a1] = classPropertyValue.f();
							}
						}
						cka.f();
					}
				}
				stopwatch.Stop();
				Trace.WriteLine("++ Processed legacy global entities: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				stopwatch.Start();
				bv9 a_3 = this.b.ac() as bv9;
				dx9.a(ref a_3);
				this.o();
				a4i.a(this.b, false);
				stopwatch.Stop();
				Trace.WriteLine("++ Фракции обновлены: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				stopwatch.Start();
				this.b.a(a_3);
				this.e.a(this.b);
				stopwatch.Stop();
				Trace.WriteLine("++ Quest and document controllers attached: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				this.e();
				this.arp(false, A_1);
				stopwatch.Reset();
				stopwatch.Start();
				if (!A_1)
				{
					this.n();
				}
				stopwatch.Stop();
				Trace.WriteLine("++ Player entity found: " + stopwatch.Elapsed.ToString());
				stopwatch.Reset();
				stopwatch.Start();
				if (this.b.v() != null && this.b.v().b() != null)
				{
					c5x c5x = this.b.v().b() as c5x;
					if (c5x != null)
					{
						a0l.a(c5x, false);
						stopwatch.Stop();
						Trace.WriteLine("++ Post transition effects applied: " + stopwatch.Elapsed.ToString());
						stopwatch.Reset();
						stopwatch.Start();
						HashSet<ya> hashSet = new HashSet<ya>();
						bax.a(new bax());
						try
						{
							foreach (ak1 ak in c5x.l)
							{
								foreach (bqt bqt in ak.TriggerProxies)
								{
									if (bqt.Trigger != null && !hashSet.Contains(bqt.Trigger))
									{
										a8o a8o = bqt.Trigger as a8o;
										if (a8o != null && a8o.vk())
										{
											bqt.Trigger.e(c5x);
										}
										hashSet.Add(bqt.Trigger);
									}
								}
							}
						}
						finally
						{
							bax.a(null);
						}
					}
				}
				bpo.GetServiceOrThrow<e5f>().asd();
			}
		}
		catch (Exception ex)
		{
			dux.b(LogSeverity.Error, "Failed to load game '{0}'. Exception: {1}", new object[]
			{
				A_0,
				ex.ToString()
			});
			throw;
		}
		finally
		{
			this.s();
			if (!A_1)
			{
				try
				{
					global::ary.a = new ary
					{
						b = false
					};
					this.d();
					this.f();
				}
				finally
				{
					global::ary.a = null;
				}
			}
			stopwatch.Stop();
			Trace.WriteLine("++ Ensured current locale ready: " + stopwatch.Elapsed.ToString());
			stopwatch.Reset();
			stopwatch.Start();
		}
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x000C25B8 File Offset: 0x000C07B8
	public a3r arj()
	{
		bpo.GetServiceOrThrow<cnk>();
		return Enumerable.FirstOrDefault<a3r>(this.arm());
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x000C25CC File Offset: 0x000C07CC
	public a3r ark()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		a3r a3r = Enumerable.FirstOrDefault<a3r>(Enumerable.Where<a3r>(this.arm(), new Func<a3r, bool>(d6f.a.a.a)));
		if (a3r == null)
		{
			return null;
		}
		if (ast.a(a3r.GameVersion, a3r.DLCs) || (ast.a(a3r.GameVersion) && serviceOrThrow.aq1().d().e()))
		{
			return null;
		}
		return a3r;
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x000C2658 File Offset: 0x000C0858
	public bool arl(string A_0)
	{
		d6f.b b = new d6f.b();
		b.a = A_0;
		return Enumerable.Any<a3r>(Enumerable.Where<a3r>(this.arm(), new Func<a3r, bool>(b.a)));
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x000C2690 File Offset: 0x000C0890
	public List<a3r> arm()
	{
		List<a3r> list = new List<a3r>();
		try
		{
			string[] directories = Directory.GetDirectories(d5x.k());
			SortedList<DateTime, a3r> sortedList = new SortedList<DateTime, a3r>();
			foreach (string text in directories)
			{
				string text2 = Path.Combine(text, "info.dat");
				if (File.Exists(text2))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text);
					string filePath = Path.Combine(text, "info.dat");
					try
					{
						a3r a3r = eoq.DeserializeFromBinaryFile<a3r>(filePath, dds.a(), true);
						a3r.Name = d6f.a(directoryInfo.Name);
						a3r.FolderName = directoryInfo.Name;
						while (sortedList.ContainsKey(a3r.SaveTime))
						{
							a3r.SaveTime = a3r.SaveTime.AddTicks(1L);
						}
						sortedList.Add(a3r.SaveTime, a3r);
					}
					catch (Exception a_)
					{
						dux.a(LogSeverity.Error, a_, "An error occurred while reading saved game info: '{0}'", new object[]
						{
							text2
						});
					}
				}
			}
			for (int j = sortedList.Count - 1; j >= 0; j--)
			{
				a3r item = sortedList.Values[j];
				list.Add(item);
			}
		}
		catch (Exception a_2)
		{
			dux.a(LogSeverity.Error, a_2, "Failed to enumerate saved games.", new object[0]);
		}
		return list;
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x000C2818 File Offset: 0x000C0A18
	public void arn(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string text = d5x.d(A_0);
			if (Directory.Exists(text))
			{
				cjf.a(text);
				Directory.Delete(text, true);
			}
		}
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x000C2850 File Offset: 0x000C0A50
	public void aro()
	{
		this.e.b();
		d6f.l();
		this.b = null;
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x000C286C File Offset: 0x000C0A6C
	public void s()
	{
		if (this.c != null)
		{
			this.c.bc(true);
		}
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x000C2888 File Offset: 0x000C0A88
	public void arp(bool A_0, bool A_1)
	{
		if (this.b.c() != null)
		{
			bfc bfc = this.ar0(this.b.c().b(), this.b);
			if (bfc == null)
			{
				dux.a(LogSeverity.CriticalError, rz.n, new object[]
				{
					this.b.c().b()
				});
				return;
			}
			alg alg = this.b.a(bfc.Id, true);
			alg.a = !d6f.a(bfc);
			if (!alg.a)
			{
				cxp value = new cxp((Version)dm9.d.Clone());
				this.b.n()[bfc.Id] = value;
			}
			b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
			c5x.a = new TimeSpan?(this.b.p());
			c5x.c = null;
			c5x.b = null;
			this.c = serviceOrThrow.yo(bfc, A_0 || A_1);
			c5x.a = null;
			c5x.c = null;
			c5x.b = null;
			d6f.e(this.c);
			this.d(this.c);
			if (this.c != null)
			{
				d6f.a(bfc, this.c, this.b);
				return;
			}
		}
		else
		{
			dux.a(LogSeverity.CriticalError, rz.a, new object[0]);
		}
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x000C29EC File Offset: 0x000C0BEC
	public void arq()
	{
		if (this.b != null && this.b.c() != null && this.c != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				service.aht();
			}
			this.c(this.c);
			b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
			this.c.CustomProperties[a46.b] = this.b.p();
			c5x.a = new TimeSpan?(this.b.p());
			serviceOrThrow.yq(this.c);
			c5x.a = null;
			this.c = null;
		}
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x000C2A9C File Offset: 0x000C0C9C
	public void arr(bool A_0)
	{
		d6f.k();
		this.c.CustomProperties[a46.b] = this.b.p();
		c5x.a = new TimeSpan?(this.b.p());
		bpo.GetServiceOrThrow<b4b>().yp(this.b.c(), this.c, A_0);
		c5x.a = null;
		d6f.j();
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x000C2B14 File Offset: 0x000C0D14
	public void ars()
	{
		this.r();
		csd csd;
		if (this.aqu().c().c() == null)
		{
			csd = Enumerable.FirstOrDefault<csd>(this.aqw().Waypoints);
		}
		else
		{
			csd = this.aqw().g(this.aqu().c().c());
		}
		if (csd == null)
		{
			dux.a(LogSeverity.CriticalError, "Failed to locate entrance waypoint '{0}'", new object[]
			{
				this.aqu().c().c()
			});
		}
		if (csd.Area == null)
		{
			dux.a(LogSeverity.CriticalError, "Entrance waypoint '{0}' could not be linked to an area ('{1}').", new object[]
			{
				this.aqu().c().c(),
				csd.AreaName
			});
		}
		c5x c5x = this.a(this.aqu().v());
		c5x.VisualDirection = HorizontalDirection.Southeast;
		c5x.q(this.aqu().v().Name);
		Vector3 vector = csd.Location;
		if (this.aqu().g() != null)
		{
			vector = new Vector3(d05.b(0f, vector.X + (float)this.aqu().g().Value.X, (float)(csd.Area.Size.c - 1)), d05.b(0f, vector.Y + (float)this.aqu().g().Value.Y, (float)(csd.Area.Size.d - 1)), vector.Z);
		}
		c5x.Location = a0l.a(csd.Area, vector, c5x, null);
		c5x.VisualDirection = csd.Direction;
		this.aqu().v().a(c5x);
		this.aqu().v().Color = adi.c;
		csd.Area.a(c5x);
		a0l.a(c5x, true);
		this.a(c5x);
		bfc bfc = this.ar0(this.aqu().c().b(), this.aqu());
		if (bfc != null)
		{
			alg alg = this.b.a(bfc.Id, true);
			b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
			serviceOrThrow.yn().LightProcessor.a();
			if (bfc.AutoReveal && !this.aqu().af().Contains(bfc.Id) && this.aqw() != null)
			{
				if (serviceOrThrow != null)
				{
					serviceOrThrow.yr(this.aqw(), this.aqu().v().c());
				}
				this.aqu().af().Add(bfc.Id);
			}
			HashSet<string> hashSet = new HashSet<string>();
			foreach (csd csd2 in this.aqw().Waypoints)
			{
				if (csd2.Name.StartsWith("global:"))
				{
					string[] array = csd2.Name.Substring(7).Split(new char[]
					{
						':'
					}, StringSplitOptions.None);
					string text = Enumerable.FirstOrDefault<string>(array);
					string a_;
					if (array.Length > 1)
					{
						a_ = array[1];
					}
					else
					{
						a_ = null;
					}
					if (a_ == string.Empty)
					{
						a_ = null;
					}
					if (!string.IsNullOrEmpty(text) && !hashSet.Contains(text))
					{
						bhb bhb;
						TimeSpan? timeSpan;
						bool flag;
						c5x c5x2 = this.a(text, bfc.Id, a_, out bhb, out timeSpan, out flag);
						if (flag)
						{
							hashSet.Add(text);
						}
						if (c5x2 != null)
						{
							aud aud = null;
							if (bhb != null && bhb.a == bfc.Id)
							{
								aud = this.c.n(bhb.b);
							}
							if (aud != null)
							{
								c5x2.Location = bhb.c;
								c5x2.VisualDirection = bhb.d;
							}
							else
							{
								aud = csd2.Area;
								c5x2.Location = csd2.Location;
								c5x2.VisualDirection = csd2.Direction;
							}
							if (c5x2.GetAspect<dqv>() == null)
							{
								dqv dqv = new dqv(c5x2);
								dqv.a(text);
								c5x2.SetAspect<dqv>(dqv);
							}
							aud.a(c5x2);
							this.a(c5x2, text, bfc.Id);
							if (timeSpan != null)
							{
								TimeSpan a_2 = this.b.o() - timeSpan.Value;
								amc aspect = c5x2.GetAspect<amc>();
								if (aspect != null)
								{
									aspect.c9(a_2);
								}
							}
						}
					}
				}
			}
			try
			{
				global::ary.a = new ary
				{
					b = true
				};
				this.f();
			}
			finally
			{
				global::ary.a = null;
			}
			for (int i = 0; i < this.aqu().x().Count; i++)
			{
				bw0 bw = this.aqu().x()[i];
				if ((bw.a() == null || string.Equals(bw.a(), bfc.Id, StringComparison.OrdinalIgnoreCase)) && bw.a(this.aqw(), this.aqu()))
				{
					this.aqu().x().RemoveAt(i);
					i--;
				}
			}
			foreach (bdw bdw in this.b(this.aqw()))
			{
				bdw.av(this.aqw(), this.aqu());
			}
			foreach (string text2 in Directory.GetFiles(d5x.q(), this.b.c().b() + "_L*.uzl"))
			{
				string text3 = Path.GetFileNameWithoutExtension(text2).ToLowerInvariant();
				int num = text3.LastIndexOf("autolayer_");
				int num2 = num + "autolayer_".Length;
				if (num != -1 && text3.Length > num2)
				{
					string text4 = text3.Substring(num2);
					string name = string.Format("autolayerImported_{0}", text3);
					if (!this.b.r().GetPrimitivePropertyValue<bool>(name, new bool?(false)).Value)
					{
						string[] array2 = text4.Split(new char[]
						{
							'_'
						}, StringSplitOptions.RemoveEmptyEntries);
						bool flag2 = false;
						string[] array3 = array2;
						for (int k = 0; k < array3.Length; k++)
						{
							string[] array4 = array3[k].Split(new char[]
							{
								'-'
							}, StringSplitOptions.RemoveEmptyEntries);
							if (array4.Length == 2)
							{
								GameDifficulty gameDifficulty;
								if (array4[0] == "dlc")
								{
									if (!dk2.b(array4[1]))
									{
										flag2 = true;
										break;
									}
								}
								else if (array4[0] == "diff" && Enum.TryParse<GameDifficulty>(array4[1], true, out gameDifficulty) && this.b.ae() < gameDifficulty)
								{
									flag2 = true;
									break;
								}
							}
							else if (array4.Length == 1 && array4[0] == "init" && alg.a)
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							doq a_3 = doq.a(text2);
							this.c.a(a_3, aju.x, new e0l());
							this.b.r()[name] = true;
						}
					}
				}
			}
			if (dk2.f())
			{
				b2p.f(this.b, this.c);
			}
			this.a(this.b, this.aqw());
			this.a(this.b, this.c, bfc);
			this.c();
			this.b();
			if (alg.a)
			{
				this.a();
			}
			alg.a = true;
			bpo.GetServiceOrThrow<e5f>().asf(bfc.Id);
			if (this.b.q().c)
			{
				dpp service = bpo.GetService<dpp>();
				if (service != null)
				{
					service.u9();
				}
			}
		}
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000C33C8 File Offset: 0x000C15C8
	public void art()
	{
		bfc bfc = this.ar0(this.aqu().c().b(), this.aqu());
		if (bfc != null)
		{
			for (int i = 0; i < this.aqu().j().Count; i++)
			{
				bw0 bw = this.aqu().j()[i];
				if ((bw.a() == null || string.Equals(bw.a(), bfc.Id, StringComparison.OrdinalIgnoreCase)) && bw.a(this.aqw(), this.aqu()))
				{
					this.aqu().j().RemoveAt(i);
					i--;
				}
			}
			foreach (bdw bdw in this.a(this.aqw()))
			{
				bdw.av(this.aqw(), this.aqu());
			}
		}
		this.b(this.b, this.c);
		bool flag = false;
		foreach (aud aud in this.c.Areas)
		{
			for (int j = aud.Entities.Count - 1; j >= 0; j--)
			{
				c5x c5x = aud.Entities[j] as c5x;
				if (c5x != null)
				{
					foreach (cn7 cn in c5x.Aspects)
					{
						bjh bjh = cn as bjh;
						if (bjh != null)
						{
							bjh.aiw();
						}
					}
					if (!flag && (c5x.g & e2b.d) == e2b.d)
					{
						flag = true;
						foreach (ejt ejt in Enumerable.ToList<ejt>(c5x.RaysEmitters))
						{
							bsf bsf = ejt as bsf;
							if (bsf != null && bsf.Definition != null && bsf.Definition.Name != null && bsf.Definition.Name.StartsWith("gearLantern", StringComparison.OrdinalIgnoreCase))
							{
								bsf.ig();
							}
						}
						d6f.b(c5x);
						c5x.an();
					}
					else
					{
						if (c5x.x.b != null)
						{
							c5x.an();
							this.a(c5x, aud, this.b.c());
						}
						do6 aspect = c5x.GetAspect<do6>();
						if (aspect != null)
						{
							aspect.a();
						}
					}
				}
			}
		}
		this.a(this.b, this.c);
		b2p.e(this.b, this.c);
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x000C3724 File Offset: 0x000C1924
	public void aru(b0b A_0, aud A_1)
	{
		this.a(A_0 as c5x, A_1, this.b.c());
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x000C3740 File Offset: 0x000C1940
	public void arv()
	{
		d6f.k();
		if (this.b == null || this.b.v() == null || this.b.v().b() == null)
		{
			dux.LogAndThrow<Exception>(LogSeverity.Error, "Player character or entity unavailable.", new object[0]);
		}
		c5x c5x = (c5x)this.b.v().b();
		bool flag = false;
		try
		{
			if (c5x.Initialized)
			{
				flag = true;
				if (c5x.h.b != null)
				{
					c5x.h.b.al();
				}
				if (c5x.l.b != null)
				{
					c5x.l.b.l();
				}
			}
			string text = d5x.h();
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			ajk ajk = new ajk();
			ajk.b = (Version)dm9.d.Clone();
			ajk.e = new List<string>(dk2.b());
			ajk.a = this.b.v();
			ajk.c = DateTime.Now;
			ajk.d = this.b.m();
			string a_ = this.c(ajk.a.Name);
			ajk.b(a_);
		}
		finally
		{
			if (flag)
			{
				if (c5x.h.b != null)
				{
					c5x.h.b.w();
				}
				if (c5x.l.b != null)
				{
					c5x.l.b.n();
				}
			}
			d6f.j();
		}
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x000C38E4 File Offset: 0x000C1AE4
	public void arw()
	{
		if (this.b != null)
		{
			bfc bfc = this.ar0(this.b.c().b(), this.b);
			if (bfc != null)
			{
				d6f.a(bfc, this.c, this.b);
			}
		}
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x000C3934 File Offset: 0x000C1B34
	public void arx()
	{
		if (this.b != null && this.b.v() != null && this.b.v().Dead)
		{
			c5x c5x = this.b.v().b() as c5x;
			if (c5x != null && c5x.j == cgy.b && c5x.h != null && c5x.h.b != null)
			{
				ny aspect = c5x.GetAspect<ny>();
				if (aspect == null || !(aspect.a() is d3q))
				{
					c5x.h.b.a(null, false);
				}
			}
		}
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x000C39E4 File Offset: 0x000C1BE4
	public bq8 ary()
	{
		if (this.b != null)
		{
			return this.b.e();
		}
		return new PropertyCollection();
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x000C3A04 File Offset: 0x000C1C04
	public bool arz(object A_0)
	{
		return cho.a(A_0);
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x000C3A10 File Offset: 0x000C1C10
	private string c(string A_0)
	{
		string text = d5x.c(A_0);
		if (!File.Exists(text))
		{
			return text;
		}
		for (int i = 0; i < 2147483647; i++)
		{
			text = d5x.c(A_0 + string.Format(" ({0})", i + 1));
			if (!File.Exists(text))
			{
				return text;
			}
		}
		dux.LogAndThrow<Exception>(LogSeverity.Error, "Could not create file path for exported character.", new object[0]);
		return null;
	}

	// Token: 0x06002363 RID: 9059 RVA: 0x000C3A84 File Offset: 0x000C1C84
	private void r()
	{
		foreach (cka cka in this.b.b().a().Values)
		{
			if (cka.g() != null && cka.d() != null)
			{
				bsb bsb = cap.a(cka.g());
				if (bsb != null && !string.Equals(bsb.b1(this.b), cka.d().a))
				{
					cka.a(null);
				}
			}
		}
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x000C3B38 File Offset: 0x000C1D38
	private void a(c5x A_0, aud A_1, c2w A_2)
	{
		if (A_0 != null && A_0.x.b.a() != null)
		{
			cka cka = this.b.b().a(A_0.x.b.a());
			cka.a(new bhb(A_2.b(), A_1.y8(), A_0.Location, A_0.VisualDirection));
			cka.a(new TimeSpan?(this.b.o()));
			cka.a(A_0);
		}
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x000C3BC0 File Offset: 0x000C1DC0
	private c5x a(string A_0, string A_1, string A_2, out bhb A_3, out TimeSpan? A_4, out bool A_5)
	{
		A_5 = false;
		b0b b0b = null;
		A_3 = null;
		A_4 = null;
		bsb bsb = cap.a(A_0);
		if (bsb != null && (bsb.cc() == null || dk2.b(bsb.cc())) && string.Equals(bsb.b1(this.b), A_1, StringComparison.OrdinalIgnoreCase) && string.Equals(bsb.ce(this.b, A_1), A_2, StringComparison.OrdinalIgnoreCase))
		{
			bool flag = false;
			A_5 = true;
			if (!this.b.b().a(A_0, out b0b, out A_3, out A_4))
			{
				flag = true;
			}
			else if (bsb.cd())
			{
				cka cka = this.b.b().b(A_0);
				if (cka != null && !cka.a())
				{
					flag = true;
				}
			}
			if (flag && bsb != null)
			{
				b0b = bsb.ho(this.b);
			}
			if (b0b != null)
			{
				bsb.cf(b0b, this.b, A_1);
				b0b.Layer = aju.x;
			}
		}
		return b0b as c5x;
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x000C3CD0 File Offset: 0x000C1ED0
	private void a(c5x A_0, string A_1, string A_2)
	{
		bsb bsb = cap.a(A_1);
		if (bsb != null)
		{
			bsb.hp(A_0, this.b, A_2);
		}
		try
		{
			if (A_0 != null && A_0.Area != null)
			{
				amc aspect = A_0.GetAspect<amc>();
				if (aspect != null)
				{
					foreach (dph dph in aspect.aa().Auras.c().Values)
					{
						bl6 bl = dph.InvocationSet as bl6;
						if (bl != null)
						{
							eru eru = bl.g as eru;
							if (eru != null)
							{
								eru.a = new EntityAspectReference<amc, amc>(aspect);
							}
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
	private static void a(bfc A_0, c1a A_1, cyt A_2)
	{
		string a_ = null;
		float? num = null;
		string classPropertyValue = A_2.r().GetClassPropertyValue<string>("MusicOverride_" + A_0.Id);
		if (classPropertyValue != null)
		{
			a_ = classPropertyValue;
			num = new float?(A_2.r().GetPrimitivePropertyValue<float>("MusicOverride_" + A_0.Id + "_Volume", new float?((float)1)).Value);
		}
		else if (A_0 != null && !string.IsNullOrEmpty(A_0.Music))
		{
			a_ = A_0.Music;
		}
		else if (A_1 != null)
		{
			a_ = A_1.CustomProperties.GetClassPropertyValue<string>(aju.y);
			num = A_1.CustomProperties.GetPrimitivePropertyValue<float>(aju.z, null);
		}
		bpo.GetServiceOrThrow<am7>().ai3(c2g.b, new bn3(a_, (num != null) ? num.Value : 1f, null, null));
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x000C3EC0 File Offset: 0x000C20C0
	private static dse q()
	{
		dse dse = null;
		try
		{
			dse = eoq.DeserializeFromBinaryFileCompressed<dse>(Path.Combine(dr3.d().lf(), ei.l), dds.a(), true);
		}
		catch (Exception a_)
		{
			dux.a(a_, LogSeverity.CriticalError, "Не удалось получить информацию о карте мира.", new object[0]);
		}
		if (dse == null)
		{
			dux.a(LogSeverity.CriticalError, "Не удалось получить информацию о карте мира.", new object[0]);
		}
		return dse;
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000C3F34 File Offset: 0x000C2134
	private void p()
	{
		this.b.r()[bp5.d("sgs")] = 1;
		this.b.r()[bp5.d("old_junkyard")] = 0;
		this.b.r()[bp5.g("ojy_main")] = true;
		this.b.r()[bp5.g("ojy_turrets")] = true;
		this.b.r()["remote_lock_ojy_k3"] = true;
		this.b.r()["remote_lock_ojy_k6"] = true;
		this.b.r().RemoveProperty("debug");
	}

	// Token: 0x0600236A RID: 9066 RVA: 0x000C4010 File Offset: 0x000C2210
	private void o()
	{
		if (this.b.r()[bp5.g("ojy_main")] == null)
		{
			this.b.r()[bp5.g("ojy_main")] = true;
		}
		if (this.b.r()[bp5.g("ojy_turrets")] == null)
		{
			this.b.r()[bp5.g("ojy_turrets")] = true;
		}
		if (this.b.r()["remote_lock_ojy_k3"] == null)
		{
			this.b.r()["remote_lock_ojy_k3"] = true;
		}
		if (this.b.r()["remote_lock_ojy_k6"] == null)
		{
			this.b.r()["remote_lock_ojy_k6"] = true;
		}
		if (this.b.r()["loc_fo5_storedOre"] == null)
		{
			this.b.r()["loc_fo5_storedOre"] = 0;
		}
		if (this.b.r()["loc_fo5_loadedOre"] == null)
		{
			this.b.r()["loc_fo5_loadedOre"] = 0;
		}
		if (this.b.r()["loc_fo5_conveyorStatus"] == null)
		{
			this.b.r()["loc_fo5_conveyorStatus"] = "off";
		}
		this.b.r().RemoveProperty("debug");
		if (dk2.f())
		{
			if (this.b.r()[bp5.l] == null)
			{
				this.b.r()[bp5.l] = new Random(this.b.l()).Next(20);
			}
			euy euy = dbp.a(this.b.l());
			if (this.b.r()[bp5.m] == null)
			{
				this.b.r()[bp5.m] = euy.a;
			}
			if (this.b.r()[bp5.o] == null)
			{
				this.b.r()[bp5.o] = euy.d;
			}
			if (this.b.r()[bp5.n] == null)
			{
				this.b.r()[bp5.n] = euy.b;
			}
		}
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x000C42C4 File Offset: 0x000C24C4
	private c5x a(au2 A_0)
	{
		c5x c5x = new c5x(aju.a);
		if (!this.aqu().r().GetPrimitivePropertyValue<bool>("introDone", new bool?(false)).Value || this.aqu().r().GetPrimitivePropertyValue<bool>("hidePlayer", new bool?(false)).Value)
		{
			c5x.ae = new float?(0f);
		}
		A_0.BaseMovementSpeed = aiy.d;
		c5x.CanTrigger = true;
		c5x.Layer = 1;
		c5x.z = new Vector2?(new Vector2(0.75f, 0.75f));
		c5x.x = true;
		amc amc = new amc(c5x, new dsx());
		amc.h(true);
		amc.a(ai5.b);
		bool value = amc.aa().CustomProperties.GetPrimitivePropertyValue<bool>(ddm.b, new bool?(false)).Value;
		c5x.c();
		if (value)
		{
			amc.a(bln.fc);
			amc.a(ai5.g);
			amc.ay().Add(new bfq("WheeledBot1Explosion"));
			List<cze> list = amc.ay();
			e01 e = new e01();
			e.a("ExplosionMedium");
			e.a(true);
			e.b(false);
			list.Add(e);
			amc.ay().Add(new bfq("WheeledBot1Rumble"));
			c5x.Size = new Vector3(1f, 1f, 2.25f);
			Dictionary<string, app> dictionary = c5x.c().e();
			string key = "engine";
			app app = new app();
			app.a("DreadnoughtEngine");
			app.b(true);
			app.a(c9z.b);
			dictionary[key] = app;
		}
		else if (A_0.b(d8o.t))
		{
			a9l.a(c5x, amc);
		}
		else
		{
			amc.a((A_0.Gender == Gender.Male) ? bln.a : bln.b);
			c5x.Size = new Vector3(1f, 1f, 1.65f);
		}
		amc.at();
		amc.i(true);
		amc.g(true);
		amc.ag().a().b().Add("HumanDie");
		c5x.SetAspect<amc>(amc);
		su aspect = new su(c5x);
		c5x.SetAspect<su>(aspect);
		mj mj = new mj(c5x, new MobileEntityAspectAccessor<amc>(c5x));
		mj.a(amc);
		c5x.SetAspect<mj>(mj);
		ny aspect2 = new ny(c5x);
		c5x.SetAspect<ny>(aspect2);
		ale aspect3 = new ale(c5x);
		c5x.SetAspect<ale>(aspect3);
		c0s aspect4 = new c0s(c5x);
		c5x.SetAspect<c0s>(aspect4);
		j7 aspect5 = new bn5(c5x);
		c5x.SetAspect<j7>(aspect5);
		bhf aspect6 = new bhf(c5x);
		c5x.SetAspect<u2>(aspect6);
		c5x.q(A_0.Name);
		ev2 ev = new ev2();
		ev.Range = this.aqu().v().SightRange;
		new c6g(A_0.c(), ev).be(c5x);
		new b1a(A_0.c()).be(c5x);
		bm6 bm = new bm6(c5x);
		bm.b("PB");
		bm.c("player");
		bm.a(new List<dkv>
		{
			new dkv("Nb", 0)
		});
		c5x.SetAspect<bm6>(bm);
		return c5x;
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x000C4614 File Offset: 0x000C2814
	private void n()
	{
		if (this.b != null && this.c != null)
		{
			foreach (aud aud in this.c.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && (c5x.g & e2b.d) == e2b.d)
					{
						this.b.v().a(c5x);
						return;
					}
				}
			}
		}
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x000C46F0 File Offset: 0x000C28F0
	private static void e(c1a A_0)
	{
		ax1 addon = A_0.GetAddon<ax1>();
		if (addon != null)
		{
			li serviceOrThrow = bpo.GetServiceOrThrow<li>();
			esj esj = bpo.GetServiceOrThrow<bef>().k0();
			esj esj2 = serviceOrThrow.j9().a;
			int num = esj.d / 2 / Convert.ToInt32(esj2.d * 2) + 2;
			int num2 = esj.c / 2 / Convert.ToInt32(esj2.c * 2) + 2;
			int num3 = Math.Abs(num2 - num);
			int num4 = Math.Abs(num + num2);
			Vector2 vector = new Vector2((float)num4, (float)num3);
			addon.apj((int)(vector.Length() * 0.75f));
			addon.apl((int)(vector.Length() * 1.25f));
			addon.apn(0f);
		}
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x000C47B0 File Offset: 0x000C29B0
	private static void m()
	{
		if (bmg.a)
		{
			d6f.l();
			string text = d5x.n();
			string text2 = d5x.m();
			string text3 = d5x.l();
			Directory.CreateDirectory(text);
			Directory.CreateDirectory(text2);
			Directory.CreateDirectory(text3);
			return;
		}
		bmg.a();
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x000C47F8 File Offset: 0x000C29F8
	private static void l()
	{
		if (bmg.a)
		{
			dr3.d();
			string text = d5x.n();
			if (Directory.Exists(text))
			{
				cjf.a(text);
				Directory.Delete(text, true);
				return;
			}
		}
		else
		{
			bmg.a();
		}
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x000C483C File Offset: 0x000C2A3C
	private static bool a(bfc A_0)
	{
		string path = d5x.m();
		string path2 = A_0.Id + "_L1.uzl";
		if (bmg.a)
		{
			string text = Path.Combine(path, path2);
			if (!File.Exists(text))
			{
				File.Copy(Path.Combine(d5x.q(), path2), text);
				return true;
			}
		}
		else
		{
			string a_ = Path.Combine(d5x.x, path2).ToLowerInvariant();
			if (!bmg.b(a_))
			{
				string a_2 = Path.Combine(d5x.q(), path2);
				bmg.a(a_, a_2);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x000C48C4 File Offset: 0x000C2AC4
	private static void k()
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amy();
		}
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x000C48E4 File Offset: 0x000C2AE4
	private static void j()
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amx();
		}
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x000C4904 File Offset: 0x000C2B04
	private void b(string A_0, bool A_1)
	{
		ps service = bpo.GetService<ps>();
		this.b.a(new bau());
		this.b.m().a = service.amz();
		this.b.m().b = service.am0();
		string a_ = Path.Combine(A_0, "global.dat");
		if (!A_1)
		{
			this.c.k();
			this.c.bd(true);
		}
		this.b.c(a_);
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x000C498C File Offset: 0x000C2B8C
	private void a(string A_0, bool A_1)
	{
		string filePath = Path.Combine(A_0, "info.dat");
		a3r a3r = new a3r();
		a3r.FolderName = Path.GetFileNameWithoutExtension(A_0);
		a3r.CharacterLevel = this.b.v().Level;
		a3r.CharacterName = this.b.v().Name;
		a3r.Transitional = A_1;
		a3r.PlayTime = new TimeSpan?(this.b.p());
		a3r.Difficulty = new GameDifficulty?(this.b.i());
		bfc bfc = this.ar0(this.b.c().b(), this.b);
		if (bfc != null)
		{
			a3r.Location = bfc.Name;
		}
		else
		{
			a3r.Location = "Unknown";
		}
		a3r.SaveTime = DateTime.Now;
		eoq.SerializeToBinaryFile<a3r>(filePath, a3r, dds.a(), eh9.c, true);
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x000C4A70 File Offset: 0x000C2C70
	public bfc ar0(string A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			string a_ = A_0;
			if (A_1 != null)
			{
				string text;
				A_1.aa().TryGetValue(A_0, out text);
				if (!string.IsNullOrEmpty(text))
				{
					a_ = text;
				}
			}
			return this.aq0().a(a_);
		}
		return null;
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x000C4AB8 File Offset: 0x000C2CB8
	private void b(string A_0)
	{
		string a_ = Path.Combine(A_0, "screenshot.png");
		if (this.b.f() != null)
		{
			try
			{
				this.b.f().a(a_);
			}
			catch (Exception a_2)
			{
				dux.a(LogSeverity.Error, a_2, "Не удалось сохранить скриншот.", new object[0]);
			}
			this.b.f().Dispose();
			this.b.a(null);
		}
	}

	// Token: 0x06002377 RID: 9079 RVA: 0x000C4B3C File Offset: 0x000C2D3C
	private static string a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return string.Empty;
		}
		return A_0.Split(new char[]
		{
			'-'
		})[0];
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x000C4B68 File Offset: 0x000C2D68
	private void d(c1a A_0)
	{
		A_0.a(new EventHandler<c4i>(this.a));
		A_0.o = new Func<double, double>(this.a);
	}

	// Token: 0x06002379 RID: 9081 RVA: 0x000C4B90 File Offset: 0x000C2D90
	private void c(c1a A_0)
	{
		A_0.b(new EventHandler<c4i>(this.a));
		A_0.o = null;
	}

	// Token: 0x0600237A RID: 9082 RVA: 0x000C4BAC File Offset: 0x000C2DAC
	private void i()
	{
		egd egd = efw.a(this.g.g().a);
		bef serviceOrThrow = bpo.GetServiceOrThrow<bef>();
		serviceOrThrow.k3(egd.a, egd.b);
		serviceOrThrow.k6(this.g.g().b);
		serviceOrThrow.k7(this.g.g().c);
		serviceOrThrow.k8();
		this.ar1(egd.h, false);
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x000C4C24 File Offset: 0x000C2E24
	private void h()
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		serviceOrThrow.adu(this.g.h().c());
		serviceOrThrow.adw(new Dictionary<c9z, float>(this.g.h().b()));
		serviceOrThrow.ad0();
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x000C4C6C File Offset: 0x000C2E6C
	private List<bdw> b(c1a A_0)
	{
		List<bdw> list = new List<bdw>();
		foreach (Property property in Enumerable.Where<Property>(A_0.CustomProperties.Properties, new Func<Property, bool>(d6f.a.a.a)))
		{
			bdw bdw = property.Value as bdw;
			if (bdw != null)
			{
				list.Add(bdw);
			}
		}
		return list;
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x000C4D08 File Offset: 0x000C2F08
	private List<bdw> a(c1a A_0)
	{
		List<bdw> list = new List<bdw>();
		foreach (Property property in Enumerable.Where<Property>(A_0.CustomProperties.Properties, new Func<Property, bool>(d6f.a.a.b)))
		{
			bdw bdw = property.Value as bdw;
			if (bdw != null)
			{
				list.Add(bdw);
			}
		}
		return list;
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x000C4DA4 File Offset: 0x000C2FA4
	private void g()
	{
		this.a(eyy.a3, eyy.b, 100);
		this.a(eyy.a4, eyy.c, 100);
		this.a(eyy.a5, eyy.d, 50);
		this.a(eyy.a6, eyy.e, 100);
		this.a(eyy.a7, eyy.f, 50);
		this.a(eyy.a8, eyy.g, 50);
		this.a(eyy.a9, eyy.h, 50);
		this.a(eyy.ba, eyy.i, 50);
		this.a(eyy.bb, eyy.j, 50);
		this.a(eyy.bc, eyy.k, 50);
		this.a(eyy.bd, eyy.l, 50);
		this.a(eyy.be, eyy.m, 50);
		this.a(eyy.bf, eyy.n, 50);
		this.a(eyy.bg, eyy.o, 50);
		this.a(eyy.bh, eyy.p, 50);
		this.a(eyy.bi, eyy.q, 50);
		this.a(eyy.bj, eyy.r, 50);
		this.a(eyy.bk, eyy.s, 50);
		this.a(eyy.bl, eyy.t, 50);
		this.a(eyy.bm, eyy.u, 50);
		this.a(eyy.bn, eyy.v, 50);
		this.a(eyy.bq, eyy.y, 50);
		this.a(eyy.bp, eyy.x, 10);
		this.a(eyy.br, eyy.z, 50);
		this.a(eyy.bs, eyy.aa, 50);
		this.a(eyy.bt, eyy.ab, 30);
		this.a(eyy.bu, eyy.ac, 15);
		this.a(eyy.bo, eyy.w, 30);
		this.a(eyy.bv, eyy.ad, 100);
		this.a(eyy.bw, eyy.ae, 50);
		this.a(eyy.bx, eyy.af, 30);
		this.a(eyy.by, eyy.ag, 30);
		this.a(eyy.bz, eyy.ah, 30);
		this.a(eyy.b0, eyy.ai, 30);
		this.a(eyy.b1, eyy.aj, 30);
		this.a(eyy.b2, eyy.ak, 10);
		this.a(eyy.b3, eyy.al, 50);
		this.a(eyy.b4, eyy.am, 10);
	}

	// Token: 0x0600237F RID: 9087 RVA: 0x000C5060 File Offset: 0x000C3260
	private void a(string A_0, string A_1, int A_2)
	{
		this.h[A_0] = new dh2(A_0, A_1, A_2);
	}

	// Token: 0x06002380 RID: 9088 RVA: 0x000C5078 File Offset: 0x000C3278
	private void f()
	{
		if (this.b != null && this.b.c() != null && this.b.c().b() != null)
		{
			bfc bfc = this.ar0(this.b.c().b(), this.aqu());
			if (bfc != null)
			{
				List<bwf> list = global::ars.a(bfc.Id);
				List<bwf> list2 = global::ars.a("*");
				List<bwf> list3 = new List<bwf>();
				if (list != null)
				{
					list3.AddRange(list);
				}
				if (list2 != null)
				{
					list3.AddRange(list2);
				}
				if (list3.Count > 0)
				{
					list3.Sort(new Comparison<bwf>(d6f.a.a.a));
					cxp cxp;
					this.b.n().TryGetValue(bfc.Id, out cxp);
					if (cxp == null)
					{
						cxp = new cxp((Version)this.b.y().Clone());
						this.b.n()[bfc.Id] = cxp;
					}
					foreach (bwf bwf in list3)
					{
						if ((bwf.AlwaysApply || cxp.a < bwf.TargetVersion) && !cxp.b(bwf.PatchId))
						{
							dux.b(LogSeverity.Information, "Applying locale patch '{0}' to locale '{1}'.", new object[]
							{
								bwf.PatchId,
								bfc.Id
							});
							try
							{
								if (bwf.Patch.b5(this.b, this.aqw()))
								{
									dux.b(LogSeverity.Information, "Successfully applied locale patch '{0}' to locale '{1}'.", new object[]
									{
										bwf.PatchId,
										bfc.Id
									});
									cxp.a(bwf.PatchId);
								}
								else
								{
									dux.b(LogSeverity.Warning, "Failed to apply locale patch '{0}' to locale '{1}'.", new object[]
									{
										bwf.PatchId,
										bfc.Id
									});
								}
							}
							catch (Exception a_)
							{
								dux.a(LogSeverity.Error, a_, "Failed to apply locale patch '{0}' to locale '{1}'.", new object[]
								{
									bwf.PatchId,
									bfc.Id
								});
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002381 RID: 9089 RVA: 0x000C5308 File Offset: 0x000C3508
	private void e()
	{
		if (this.b != null)
		{
			foreach (mg mg in global::ars.e())
			{
				if (this.b.y() < mg.b && !this.b.x.Contains(mg.a))
				{
					dux.b(LogSeverity.Information, "Applying global patch '{0}'.", new object[]
					{
						mg.a
					});
					if (mg.c.ee(this.b))
					{
						dux.b(LogSeverity.Information, "Successfully applied global patch '{0}'.", new object[]
						{
							mg.a
						});
						this.b.x.Add(mg.a);
					}
					else
					{
						dux.b(LogSeverity.Warning, "Failed to apply global patch '{0}'.", new object[]
						{
							mg.a
						});
					}
				}
			}
		}
	}

	// Token: 0x06002382 RID: 9090 RVA: 0x000C5420 File Offset: 0x000C3620
	private void d()
	{
		if (this.b != null && this.c != null)
		{
			foreach (mg mg in global::ars.e())
			{
				if (mg.d != null && this.b.y() < mg.b && !this.b.y.Contains(mg.a))
				{
					dux.b(LogSeverity.Information, "Applying locale global patch '{0}'.", new object[]
					{
						mg.a
					});
					if (mg.d.x5(this.b, this.c))
					{
						dux.b(LogSeverity.Information, "Successfully applied locale global patch '{0}'.", new object[]
						{
							mg.a
						});
						this.b.y.Add(mg.a);
					}
					else
					{
						dux.b(LogSeverity.Warning, "Failed to apply locale global patch '{0}'.", new object[]
						{
							mg.a
						});
					}
				}
			}
		}
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x000C5554 File Offset: 0x000C3754
	private void b(cyt A_0, c1a A_1)
	{
		d60 d = A_1.a();
		if (d != null)
		{
			List<b0b> list = d.ab4(new string[]
			{
				"SurvivingSnitch"
			});
			if (list != null && list.Count > 0)
			{
				bv9 bv = A_0.ac() as bv9;
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().a(A_0.ac(), asp.a) == global::h.a)
					{
						bv.a(c5x.h.b.aa().FactionId, asp.a, global::h.a, null, true, false, false);
					}
				}
			}
		}
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x000C5650 File Offset: 0x000C3850
	private void a(cyt A_0, c1a A_1, bfc A_2)
	{
		Random random = new Random(A_0.l() + A_1.qe().GetHashCode() + (int)A_0.p().TotalMinutes);
		alg alg = this.b.a(A_2.Id, true);
		bool flag = alg != null && !alg.a;
		a0a a0a;
		if (!A_0.ab().TryGetValue(A_0.c().b(), out a0a))
		{
			a0a = new a0a();
			A_0.ab()[A_0.c().b()] = a0a;
		}
		if (A_2.StaticRandomEvents && !flag)
		{
			return;
		}
		if ((a0a.a.Count == 0 && a0a.b == null) || a0a.b.Value < A_0.p())
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					bop bop = ya as bop;
					if (bop != null && bop.g() != null && bop.g().Count > 0)
					{
						List<ccn> list = c1h.a(bop.g());
						List<ccn> list2 = new List<ccn>();
						using (List<ccn>.Enumerator enumerator3 = list.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								ccn ccn = enumerator3.Current;
								bool flag2 = (bop.b() != null) ? bop.b().Value : ccn.IsStatic;
								if ((!ccn.Singular || !A_0.d().Contains(ccn.Id)) && (!ccn.Unique || !A_0.k().Contains(ccn.Id)) && (ccn.Dlc == null || dk2.b(ccn.Dlc)) && A_0.ae() >= ccn.MinimalGameDifficulty && !a0a.c.Contains(ccn.Id) && (flag || !flag2))
								{
									list2.Add(ccn);
								}
							}
							goto IL_3BB;
						}
						IL_268:
						int index = random.Next(list2.Count);
						ccn ccn2 = list2[index];
						list2.Remove(ccn2);
						if (ccn2.e2(A_0, A_1, bop))
						{
							if (random.NextDouble() < ccn2.TriggeringChance)
							{
								ccn2.ov(A_0, A_1, bop);
								a0a.a.Add(ccn2.Id);
								a0a.c.Add(ccn2.Id);
								if (ccn2.Singular)
								{
									A_0.d().Add(ccn2.Id);
								}
								if (ccn2.Unique)
								{
									A_0.k().Add(ccn2.Id);
									goto IL_3C8;
								}
								goto IL_3C8;
							}
							else
							{
								foreach (string text in ccn2.Categories)
								{
									if (text != e3a.f)
									{
										for (int i = list2.Count - 1; i >= 0; i--)
										{
											ccn ccn3 = list2[i];
											if (ccn3.Categories != null && ccn3.Categories.Contains(text))
											{
												list2.RemoveAt(i);
											}
										}
									}
								}
							}
						}
						IL_3BB:
						if (list2.Count > 0)
						{
							goto IL_268;
						}
					}
					IL_3C8:
					if (a0a.a.Count > 0)
					{
						break;
					}
				}
			}
			a0a.b = new TimeSpan?(A_0.p() + e3a.g);
		}
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x000C5AFC File Offset: 0x000C3CFC
	private void a(cyt A_0, c1a A_1)
	{
		a0a a0a;
		if (!A_0.ab().TryGetValue(A_0.c().b(), out a0a))
		{
			a0a = new a0a();
			A_0.ab()[A_0.c().b()] = a0a;
			return;
		}
		List<string> list = new List<string>();
		foreach (string text in a0a.a)
		{
			ccn ccn = c1h.a(text);
			bool flag = ccn == null || ccn.kg(A_0, A_1);
			if (flag)
			{
				list.Add(text);
			}
		}
		foreach (string text2 in list)
		{
			a0a.a.Remove(text2);
			A_0.d().Remove(text2);
		}
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x000C5C1C File Offset: 0x000C3E1C
	private void c()
	{
		d60 addon = this.aqw().GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				aju.b3
			}))
			{
				b0b.Zone.ActionManager.g9(new c7(b0b, false, false, true, false), atp.a);
			}
		}
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x000C5CAC File Offset: 0x000C3EAC
	private void b()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		foreach (aud aud in this.c.Areas)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				foreach (cn7 cn in Enumerable.ToList<cn7>(((c5x)b0b).Aspects))
				{
					cwd cwd = cn as cwd;
					if (cwd != null)
					{
						cwd.aqi();
					}
				}
			}
		}
		stopwatch.Stop();
		Trace.WriteLine("Число мест: " + stopwatch.Elapsed.ToString());
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x000C5DD8 File Offset: 0x000C3FD8
	private void a()
	{
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.a8().IsPlayer)
				{
					bm6 aspect = d4n.b.a8().GetAspect<bm6>();
					if (aspect != null)
					{
						erl erl = aspect.a(aju.a);
						if (erl != null && erl.f() != cem.d)
						{
							erl.a();
						}
					}
				}
			}
		}
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x000C5EA8 File Offset: 0x000C40A8
	private static void b(c5x A_0)
	{
		if (A_0 != null && A_0.IsPlayer)
		{
			ar7 classPropertyValue = A_0.d().a().GetClassPropertyValue<ar7>(bah.c);
			if (classPropertyValue != null && classPropertyValue.ao() != null)
			{
				bdf aspect = classPropertyValue.ao().GetAspect<bdf>();
				if (aspect != null)
				{
					aspect.r9(true);
				}
				crm.a(classPropertyValue.ao(), "PlayerTowedEntity");
			}
		}
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x000C5F18 File Offset: 0x000C4118
	private void a(c5x A_0)
	{
		HorizontalDirection a_ = aw1.b(A_0.VisualDirection);
		bt4 bt = new bt4(A_0.Area.y8(), A_0.Location);
		ak1 ak = A_0.Area.a(A_0.aj().a());
		if (ak != null)
		{
			ak1 ak2 = aw1.a(ak, a_);
			if (ak2 != null)
			{
				bt.a(ak2.Location.a());
			}
		}
		c5x c5x = crm.a("PlayerTowedEntity", bt) as c5x;
		if (c5x != null)
		{
			bdf aspect = c5x.GetAspect<bdf>();
			if (aspect != null)
			{
				aspect.r8(A_0, true);
			}
			Vector3 a_2 = a0l.a(A_0.Area, bt.a(), c5x, new l9?(aw1.a(A_0)));
			c5x.Location = a_2;
			c5x.ah();
			aw1.b(c5x, A_0, true);
		}
	}

	// Token: 0x0600238B RID: 9099 RVA: 0x000C5FF0 File Offset: 0x000C41F0
	public void ar1(float A_0, bool A_1)
	{
		if (this.k != A_0)
		{
			this.k = A_0;
			if (A_1)
			{
				dka dka = bpo.GetService<ps>() as dka;
				if (dka != null && dka.ac() != null)
				{
					dka.ac().s().a();
				}
			}
		}
	}

	// Token: 0x0600238C RID: 9100 RVA: 0x000C6044 File Offset: 0x000C4244
	private void a(object A_0, c4i A_1)
	{
		if (this.b != null)
		{
			cyt cyt = this.b;
			cyt.a(cyt.p() + A_1.a);
			if (!dz6.e())
			{
				cyt cyt2 = this.b;
				cyt2.b(cyt2.o() + A_1.a);
			}
		}
	}

	// Token: 0x0600238D RID: 9101 RVA: 0x000C60A0 File Offset: 0x000C42A0
	public GameDifficultySettings ar2()
	{
		GameDifficulty gameDifficulty = GameDifficulty.Normal;
		if (this.b != null)
		{
			gameDifficulty = this.aqu().i();
		}
		if (gameDifficulty == GameDifficulty.Custom)
		{
			if (this.aqu().r != null)
			{
				return this.aqu().r;
			}
			gameDifficulty = GameDifficulty.Normal;
		}
		return aiy.cp[(int)gameDifficulty];
	}

	// Token: 0x0600238F RID: 9103 RVA: 0x000C6110 File Offset: 0x000C4310
	[CompilerGenerated]
	private double a(double A_0)
	{
		ps service = bpo.GetService<ps>();
		if (service != null && service.alk())
		{
			return A_0;
		}
		if (dz6.e())
		{
			return A_0;
		}
		if (this.aqu() != null && this.aqu().v() != null)
		{
			if (this.aqu().v().Vehicle != null)
			{
				return A_0;
			}
			if (this.aqu().v().EncumbranceLevel > db9.a)
			{
				return A_0;
			}
		}
		return A_0 * (1.0 + (double)this.j * d6f.a);
	}

	// Token: 0x040014A7 RID: 5287
	private static readonly double a = 0.25;

	// Token: 0x040014A8 RID: 5288
	private cyt b;

	// Token: 0x040014A9 RID: 5289
	private c1a c;

	// Token: 0x040014AA RID: 5290
	private dka d;

	// Token: 0x040014AB RID: 5291
	private ek2 e = new ek2();

	// Token: 0x040014AC RID: 5292
	private dse f;

	// Token: 0x040014AD RID: 5293
	private ls g;

	// Token: 0x040014AE RID: 5294
	private Dictionary<string, dh2> h = new Dictionary<string, dh2>();

	// Token: 0x040014AF RID: 5295
	private double i;

	// Token: 0x040014B0 RID: 5296
	private int j;

	// Token: 0x040014B1 RID: 5297
	private float k = 1f;

	// Token: 0x02000561 RID: 1377
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060023BD RID: 9149 RVA: 0x000C61BC File Offset: 0x000C43BC
		internal bool a(a3r A_0)
		{
			return string.Equals(A_0.FolderName, "quicksave", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000C61D0 File Offset: 0x000C43D0
		internal bool a(Property A_0)
		{
			return A_0.Name.StartsWith("FixedPreprocessor", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000C61E4 File Offset: 0x000C43E4
		internal bool b(Property A_0)
		{
			return A_0.Name.StartsWith("FixedPostprocessor", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x000C61F8 File Offset: 0x000C43F8
		internal int a(bwf A_0, bwf A_1)
		{
			if (!(A_0.TargetVersion < A_1.TargetVersion))
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x040014B2 RID: 5298
		public static readonly d6f.a a = new d6f.a();

		// Token: 0x040014B3 RID: 5299
		public static Func<a3r, bool> b;

		// Token: 0x040014B4 RID: 5300
		public static Func<Property, bool> c;

		// Token: 0x040014B5 RID: 5301
		public static Func<Property, bool> d;

		// Token: 0x040014B6 RID: 5302
		public static Comparison<bwf> e;
	}

	// Token: 0x02000562 RID: 1378
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x060023C2 RID: 9154 RVA: 0x000C621C File Offset: 0x000C441C
		internal bool a(a3r A_0)
		{
			return A_0.FolderName == this.a;
		}

		// Token: 0x040014B7 RID: 5303
		public string a;
	}
}
