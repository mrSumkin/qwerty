using System;
using System.Runtime.Serialization;

// Token: 0x02001965 RID: 6501
[eiz("DE2")]
[Serializable]
public abstract class wq : ISerializable, cq6
{
	// Token: 0x06008B0D RID: 35597 RVA: 0x0038E8FC File Offset: 0x0038CAFC
	protected wq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06008B0E RID: 35598 RVA: 0x0038E904 File Offset: 0x0038CB04
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06008B0F RID: 35599 RVA: 0x0038E908 File Offset: 0x0038CB08
	public virtual bool Negative
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06008B10 RID: 35600 RVA: 0x0038E90C File Offset: 0x0038CB0C
	public virtual string TickJob
	{
		get
		{
			return null;
		}
	}

	// Token: 0x06008B11 RID: 35601 RVA: 0x0038E910 File Offset: 0x0038CB10
	protected wq()
	{
	}

	// Token: 0x06008B12 RID: 35602 RVA: 0x0038E918 File Offset: 0x0038CB18
	public virtual string dm()
	{
		return null;
	}

	// Token: 0x06008B13 RID: 35603 RVA: 0x0038E91C File Offset: 0x0038CB1C
	public override string ToString()
	{
		return this.dm();
	}

	// Token: 0x06008B14 RID: 35604
	public abstract wq dn();

	// Token: 0x06008B15 RID: 35605
	public abstract void dk(ll A_0, int A_1);

	// Token: 0x06008B16 RID: 35606
	public abstract void dl(ll A_0, int A_1);

	// Token: 0x06008B17 RID: 35607 RVA: 0x0038E924 File Offset: 0x0038CB24
	protected virtual void @do(wq A_0)
	{
	}
}
