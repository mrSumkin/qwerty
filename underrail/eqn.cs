using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Ouroboros.Core.Logging;

// Token: 0x02000165 RID: 357
internal class eqn : epf
{
	// Token: 0x060008F9 RID: 2297 RVA: 0x00025594 File Offset: 0x00023794
	[CompilerGenerated]
	public void at1(EventHandler A_0)
	{
		EventHandler eventHandler = this.j;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x000255CC File Offset: 0x000237CC
	[CompilerGenerated]
	public void at2(EventHandler A_0)
	{
		EventHandler eventHandler = this.j;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.j, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00025604 File Offset: 0x00023804
	public eqn(azm A_0, bmz A_1, bq8 A_2, bq8 A_3)
	{
		czh.a(A_0, "dialogModel");
		czh.a(A_1, "dialogManager");
		this.f = A_0;
		this.g = A_1;
		this.a = A_0.e();
		this.b = A_0.f();
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00025678 File Offset: 0x00023878
	public string at3()
	{
		return this.a;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00025680 File Offset: 0x00023880
	public string at4()
	{
		return this.b;
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00025688 File Offset: 0x00023888
	public bq8 at5()
	{
		return this.c;
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00025690 File Offset: 0x00023890
	public bq8 at6()
	{
		return this.d;
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00025698 File Offset: 0x00023898
	public ej9 at7()
	{
		return this.e;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x000256A0 File Offset: 0x000238A0
	public ReadOnlyCollection<string> at8()
	{
		return this.h.AsReadOnly();
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x000256B0 File Offset: 0x000238B0
	public string at9()
	{
		return this.g.yz();
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x000256C0 File Offset: 0x000238C0
	public void aua()
	{
		this.a(this.f.b());
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x000256D4 File Offset: 0x000238D4
	public void aub()
	{
		this.e = null;
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x000256E0 File Offset: 0x000238E0
	public void auc(string A_0)
	{
		eqn.a a = new eqn.a();
		a.a = A_0;
		czh.a(a.a, "answerName");
		aof aof = Enumerable.FirstOrDefault<aof>(Enumerable.Where<aof>(this.e.d(), new Func<aof, bool>(a.a)));
		if (aof != null)
		{
			this.a(aof.Answer);
			return;
		}
		string str = "Answer with name '" + a.a + "' could not be found in list of possible answers to question.";
		if (this.i != null && this.i.n8() && this.i.n9(LogSeverity.Error, 115))
		{
			this.i.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x0002579C File Offset: 0x0002399C
	public void aud(int A_0)
	{
		try
		{
			if (this.e.d().Count == 0)
			{
				this.aue();
			}
			else
			{
				d55 a_ = this.e.d()[A_0].Answer;
				this.a(a_);
			}
		}
		catch (Exception ex)
		{
			if (this.i != null && this.i.n8() && this.i.n9(LogSeverity.Error, 115))
			{
				this.i.n7(LogSeverity.Error, 115, "[Dialog Manager] Error while answering the question. Exception: " + ex.ToString());
			}
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00025850 File Offset: 0x00023A50
	public void aue()
	{
		d55 a_ = null;
		if (this.e != null && this.e.e() != null && this.e.e().PossibleNextSteps != null)
		{
			a_ = this.e.e().c(this.c, this.d);
		}
		this.a(a_);
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x000258B4 File Offset: 0x00023AB4
	private void a(d55 A_0)
	{
		d55 d = A_0;
		try
		{
			while (d != null)
			{
				this.h.Add(d.Name);
				dzc dzc = d as dzc;
				if (dzc != null)
				{
					EventHandler eventHandler = this.j;
					if (eventHandler != null)
					{
						eventHandler(dzc, new EventArgs());
					}
					dzc.b(this.c, this.d);
				}
				ad7 ad = d as ad7;
				if (ad != null)
				{
					this.a(ad);
					this.e = new ej9(ad, this);
					return;
				}
				d = d.c(this.c, this.d);
			}
			this.e = null;
		}
		catch (Exception ex)
		{
			string str = "Error occured during executing dialog engine. ";
			if (this.i != null && this.i.n8() && this.i.n9(LogSeverity.Error, 115))
			{
				this.i.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str + "Exception: " + ex.ToString());
			}
		}
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x000259D0 File Offset: 0x00023BD0
	private void a(ad7 A_0)
	{
		bj9 bj = null;
		if (!string.IsNullOrEmpty(A_0.h()))
		{
			if (!this.a(ref bj))
			{
				return;
			}
			bj.ae4(A_0.h(), null, null, new Dictionary<string, object>
			{
				{
					"element",
					A_0
				}
			});
		}
		foreach (atr atr in A_0.PossibleAnswers)
		{
			if (!string.IsNullOrEmpty(atr.h()))
			{
				if (!this.a(ref bj))
				{
					break;
				}
				bj.ae4(atr.h(), null, null, new Dictionary<string, object>
				{
					{
						"element",
						atr
					}
				});
			}
		}
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x00025AA0 File Offset: 0x00023CA0
	private bool a(ref bj9 A_0)
	{
		if (A_0 == null)
		{
			A_0 = bpo.GetService<bj9>();
		}
		return A_0 != null;
	}

	// Token: 0x040005D2 RID: 1490
	private string a;

	// Token: 0x040005D3 RID: 1491
	private string b;

	// Token: 0x040005D4 RID: 1492
	private bq8 c;

	// Token: 0x040005D5 RID: 1493
	private bq8 d;

	// Token: 0x040005D6 RID: 1494
	private ej9 e;

	// Token: 0x040005D7 RID: 1495
	private azm f;

	// Token: 0x040005D8 RID: 1496
	private bmz g;

	// Token: 0x040005D9 RID: 1497
	private List<string> h = new List<string>();

	// Token: 0x040005DA RID: 1498
	private cvq i = dr3.e();

	// Token: 0x040005DB RID: 1499
	[CompilerGenerated]
	private EventHandler j;

	// Token: 0x02000166 RID: 358
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x00025AC0 File Offset: 0x00023CC0
		internal bool a(aof A_0)
		{
			return A_0.Answer.Name == this.a;
		}

		// Token: 0x040005DC RID: 1500
		public string a;
	}
}
