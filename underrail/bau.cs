using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000673 RID: 1651
[eiz("GB")]
[Serializable]
public sealed class bau : ISerializable
{
	// Token: 0x060029EA RID: 10730 RVA: 0x000ED9DC File Offset: 0x000EBBDC
	private bau(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cl7)A_0.GetValue("GB:ABB", typeof(cl7));
			if (ell.a() >= 130)
			{
				this.b = (TimelapseTextFeeds)A_0.GetValue("GB:F", typeof(TimelapseTextFeeds));
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(bau))
			{
				this.a = (cl7)A_0.GetValue("ActionBarBindings", typeof(cl7));
				return;
			}
			this.a = (cl7)A_0.GetValue("GameBindings+ActionBarBindings", typeof(cl7));
		}
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x000EDAA4 File Offset: 0x000EBCA4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("GB:ABB", this.a);
		info.AddValue("GB:F", this.b);
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x000EDAD0 File Offset: 0x000EBCD0
	public bau()
	{
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x000EDAD8 File Offset: 0x000EBCD8
	public void b(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<bau>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x000EDAF8 File Offset: 0x000EBCF8
	public static bau a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<bau>(A_0, dds.a(), true);
	}

	// Token: 0x040016D7 RID: 5847
	public cl7 a;

	// Token: 0x040016D8 RID: 5848
	public TimelapseTextFeeds b;
}
