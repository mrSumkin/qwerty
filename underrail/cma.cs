using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

// Token: 0x02000151 RID: 337
[eiz("CC")]
[Serializable]
public abstract class cma : dnh, ISerializable, c7m
{
	// Token: 0x06000859 RID: 2137 RVA: 0x0002317C File Offset: 0x0002137C
	protected cma(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() >= 39)
		{
			di7.ReadList<dnh>("CC:EC", ref this.a, A_0);
			return;
		}
		if (ell.b() != 0)
		{
			Collection<dnh> collection = null;
			di7.ReadCollection<dnh>("CC:EC", ref collection, A_0);
			if (collection != null)
			{
				this.a = new List<dnh>(collection);
				return;
			}
			this.a = new List<dnh>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(cma))
			{
				Collection<dnh> collection2 = (Collection<dnh>)A_0.GetValue("_ExecutingConditions", typeof(Collection<dnh>));
				this.a = new List<dnh>(collection2);
				return;
			}
			Collection<dnh> collection3 = (Collection<dnh>)A_0.GetValue("CompositeCondition+_ExecutingConditions", typeof(Collection<dnh>));
			this.a = new List<dnh>(collection3);
			return;
		}
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0002325C File Offset: 0x0002145C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<dnh>("CC:EC", this.a, info);
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00023278 File Offset: 0x00021478
	public List<dnh> a()
	{
		return this.a;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00023280 File Offset: 0x00021480
	public void a(List<dnh> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002328C File Offset: 0x0002148C
	public cma()
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x000232A4 File Offset: 0x000214A4
	public new bool h5(string A_0, bool A_1)
	{
		foreach (c7m c7m in this.a)
		{
			if (c7m != null && c7m.h5(A_0, A_1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x040005A8 RID: 1448
	private List<dnh> a = new List<dnh>();
}
