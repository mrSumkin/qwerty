using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02000422 RID: 1058
[fe("neutralAnimal")]
public class fs : ua
{
	// Token: 0x06001BAC RID: 7084 RVA: 0x000976A4 File Offset: 0x000958A4
	public fs(bm6 A_0) : base("NeutralAnimalBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		string a_ = "FulfillNoiseBackupRequest";
		Func<TimeSpan, double, bool> a_2 = new Func<TimeSpan, double, bool>(this.j);
		Func<bool, float> a_3 = new Func<bool, float>(fs.a.a.d);
		List<c96> list2 = new List<c96>();
		list2.Add(new b64("ChangeBackupLocation", new Func<TimeSpan, double, bool>(this.i), new Func<TimeSpan, double, ej1>(this.h), new Func<bool, float>(fs.a.a.c), null));
		list2.Add(new ere("RangedBackup", new Func<TimeSpan, double, bool>(this.g), new Func<bool, float>(fs.a.a.b), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.f))
			{
				f = dnw.c,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.e),
				b = new Action<TimeSpan, double>(this.d),
				e = 3000
			}
		}));
		list2.Add(new ere("MeleeBackup", new Func<TimeSpan, double, bool>(fs.a.a.a), new Func<bool, float>(fs.a.a.a), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.c))
			{
				f = dnw.b,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.b),
				b = new Action<TimeSpan, double>(this.a),
				e = 3000
			}
		}));
		list.Add(new ere(a_, a_2, a_3, list2));
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.75f
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x000979A8 File Offset: 0x00095BA8
	[CompilerGenerated]
	private bool j(TimeSpan A_0, double A_1)
	{
		return eth.f(this.Subject) != null || eth.g(this.Subject) != null;
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x000979CC File Offset: 0x00095BCC
	[CompilerGenerated]
	private bool i(TimeSpan A_0, double A_1)
	{
		ak1 ak = eth.g(this.Subject);
		ak1 ak2 = eth.f(this.Subject);
		return ak2 != null && ak != ak2;
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00097A04 File Offset: 0x00095C04
	[CompilerGenerated]
	private ej1 h(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().SpecialStates.g)
		{
			a20.a(this.Subject.a8(), null, new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Special_HeardNoise
			});
		}
		this.Subject.y6()[ddq.am] = this.Subject.y6()[ddq.an];
		this.Subject.y6().RemoveProperty(ddq.an);
		return ej1.b;
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00097A8C File Offset: 0x00095C8C
	[CompilerGenerated]
	private bool g(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00097ABC File Offset: 0x00095CBC
	[CompilerGenerated]
	private ak1 f(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00097ACC File Offset: 0x00095CCC
	[CompilerGenerated]
	private void e(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00097ADC File Offset: 0x00095CDC
	[CompilerGenerated]
	private void d(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00097AEC File Offset: 0x00095CEC
	[CompilerGenerated]
	private new ak1 c(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x00097AFC File Offset: 0x00095CFC
	[CompilerGenerated]
	private void b(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x00097B0C File Offset: 0x00095D0C
	[CompilerGenerated]
	private void a(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x02000423 RID: 1059
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x00097B30 File Offset: 0x00095D30
		internal float d(bool A_0)
		{
			return 0.77f;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00097B38 File Offset: 0x00095D38
		internal float c(bool A_0)
		{
			return 2f;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00097B40 File Offset: 0x00095D40
		internal float b(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00097B48 File Offset: 0x00095D48
		internal bool a(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00097B4C File Offset: 0x00095D4C
		internal float a(bool A_0)
		{
			return 0.5f;
		}

		// Token: 0x04000F52 RID: 3922
		public static readonly fs.a a = new fs.a();

		// Token: 0x04000F53 RID: 3923
		public static Func<bool, float> b;

		// Token: 0x04000F54 RID: 3924
		public static Func<bool, float> c;

		// Token: 0x04000F55 RID: 3925
		public static Func<bool, float> d;

		// Token: 0x04000F56 RID: 3926
		public static Func<TimeSpan, double, bool> e;

		// Token: 0x04000F57 RID: 3927
		public static Func<bool, float> f;
	}
}
