using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02000159 RID: 345
[eiz("Q")]
[Serializable]
public class ad7 : dzc, ISerializable
{
	// Token: 0x0600089C RID: 2204 RVA: 0x000242E8 File Offset: 0x000224E8
	protected ad7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadCollection<atr>("Q:PA", ref this.a, A_0);
			this.b = (ax8)A_0.GetValue("Q:Q", typeof(ax8));
			this.c = (ax8)A_0.GetValue("Q:A", typeof(ax8));
			return;
		}
		if (base.GetType() == typeof(ad7))
		{
			this.a = (Collection<atr>)A_0.GetValue("_PossibleAnswers", typeof(Collection<atr>));
			this.b = (ax8)A_0.GetValue("_Questioner", typeof(ax8));
			this.c = (ax8)A_0.GetValue("_Answerer", typeof(ax8));
			return;
		}
		this.a = (Collection<atr>)A_0.GetValue("Question+_PossibleAnswers", typeof(Collection<atr>));
		this.b = (ax8)A_0.GetValue("Question+_Questioner", typeof(ax8));
		this.c = (ax8)A_0.GetValue("Question+_Answerer", typeof(ax8));
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00024440 File Offset: 0x00022640
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteCollection<atr>("Q:PA", this.a, info);
		info.AddValue("Q:Q", this.b);
		info.AddValue("Q:A", this.c);
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600089E RID: 2206 RVA: 0x00024480 File Offset: 0x00022680
	public Collection<atr> PossibleAnswers
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600089F RID: 2207 RVA: 0x00024488 File Offset: 0x00022688
	// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00024490 File Offset: 0x00022690
	public ax8 Questioner
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0002449C File Offset: 0x0002269C
	// (set) Token: 0x060008A2 RID: 2210 RVA: 0x000244A4 File Offset: 0x000226A4
	public ax8 Answerer
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x000244B0 File Offset: 0x000226B0
	public ad7()
	{
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x000244C4 File Offset: 0x000226C4
	public ad7(string A_0) : base(A_0)
	{
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x000244DC File Offset: 0x000226DC
	public Collection<atr> a(bq8 A_0, bq8 A_1)
	{
		Collection<atr> collection = new Collection<atr>();
		atr atr = null;
		foreach (atr atr2 in this.a)
		{
			if (atr == null && atr2.a())
			{
				atr = atr2;
			}
			bool flag = false;
			bool a_ = atr2.d();
			try
			{
				flag = (atr2.CausingCondition == null || atr2.CausingCondition.cw(A_0, A_1));
			}
			catch (Exception ex)
			{
				cvq service = bpo.GetService<cvq>();
				if (service != null && service.n8() && service.n9(LogSeverity.Error, 115))
				{
					string a_2 = string.Format("[Dialog Manager] - Error occurred while evaluation condition '{0}'. Exception: {1}", atr2.CausingCondition.h(), ex.ToString());
					service.n7(LogSeverity.Error, 115, a_2);
				}
			}
			try
			{
				if (atr2.b() != null)
				{
					a_ = atr2.b().cw(A_0, A_1);
				}
			}
			catch (Exception ex2)
			{
				cvq service2 = bpo.GetService<cvq>();
				if (service2 != null && service2.n8() && service2.n9(LogSeverity.Error, 115))
				{
					string a_3 = string.Format("[Dialog Manager] - Error occurred while evaluation condition '{0}'. Exception: {1}", atr2.b().h(), ex2.ToString());
					service2.n7(LogSeverity.Error, 115, a_3);
				}
			}
			atr2.a(a_);
			if (flag)
			{
				collection.Add(atr2);
			}
		}
		if (collection.Count == 0 && atr != null)
		{
			collection.Add(atr);
		}
		return collection;
	}

	// Token: 0x040005BA RID: 1466
	private new Collection<atr> a = new Collection<atr>();

	// Token: 0x040005BB RID: 1467
	private new ax8 b;

	// Token: 0x040005BC RID: 1468
	private new ax8 c;
}
