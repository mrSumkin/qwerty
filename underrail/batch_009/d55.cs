using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200014D RID: 333
[eiz("CE")]
[Serializable]
public abstract class d55 : ISerializable
{
	// Token: 0x0600083B RID: 2107 RVA: 0x00022A8C File Offset: 0x00020C8C
	protected d55(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (dnh)A_0.GetValue("CE:CC", typeof(dnh));
			di7.ReadCollection<d55>("CE:PNS", ref this.b, A_0);
			this.c = A_0.GetString("CE:N");
			return;
		}
		if (base.GetType() == typeof(d55))
		{
			this.a = (dnh)A_0.GetValue("_CausingCondition", typeof(dnh));
			this.b = (Collection<d55>)A_0.GetValue("_PossibleNextSteps", typeof(Collection<d55>));
			this.c = A_0.GetString("_Name");
			return;
		}
		this.a = (dnh)A_0.GetValue("ConditionalElement+_CausingCondition", typeof(dnh));
		this.b = (Collection<d55>)A_0.GetValue("ConditionalElement+_PossibleNextSteps", typeof(Collection<d55>));
		this.c = A_0.GetString("ConditionalElement+_Name");
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00022BB4 File Offset: 0x00020DB4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CE:CC", this.a);
		di7.WriteCollection<d55>("CE:PNS", this.b, info);
		info.AddValue("CE:N", this.c);
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600083D RID: 2109 RVA: 0x00022BEC File Offset: 0x00020DEC
	// (set) Token: 0x0600083E RID: 2110 RVA: 0x00022BF4 File Offset: 0x00020DF4
	public dnh CausingCondition
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600083F RID: 2111 RVA: 0x00022C00 File Offset: 0x00020E00
	public Collection<d55> PossibleNextSteps
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000840 RID: 2112 RVA: 0x00022C08 File Offset: 0x00020E08
	// (set) Token: 0x06000841 RID: 2113 RVA: 0x00022C10 File Offset: 0x00020E10
	public string Name
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

	// Token: 0x06000842 RID: 2114 RVA: 0x00022C1C File Offset: 0x00020E1C
	public d55() : this(Guid.NewGuid().ToString())
	{
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00022C44 File Offset: 0x00020E44
	public d55(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x00022C60 File Offset: 0x00020E60
	public virtual d55 c(bq8 A_0, bq8 A_1)
	{
		cvq cvq = dr3.e();
		foreach (d55 d in this.b)
		{
			try
			{
				if (d.CausingCondition == null || d.CausingCondition.cw(A_0, A_1))
				{
					return d;
				}
			}
			catch (Exception ex)
			{
				if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 115))
				{
					cvq.n7(LogSeverity.Warning, 115, "[Dialog Manager] Error while evaluating condition. Exception: " + ex.ToString());
				}
			}
		}
		return null;
	}

	// Token: 0x040005A2 RID: 1442
	private dnh a;

	// Token: 0x040005A3 RID: 1443
	private Collection<d55> b = new Collection<d55>();

	// Token: 0x040005A4 RID: 1444
	private string c;
}
