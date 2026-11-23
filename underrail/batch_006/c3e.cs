using System;
using System.Runtime.Serialization;

// Token: 0x02001B4E RID: 6990
[eiz("AIM")]
[Serializable]
public abstract class c3e : ISerializable
{
	// Token: 0x06009739 RID: 38713 RVA: 0x003B0390 File Offset: 0x003AE590
	protected c3e(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600973A RID: 38714 RVA: 0x003B0398 File Offset: 0x003AE598
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600973B RID: 38715 RVA: 0x003B039C File Offset: 0x003AE59C
	protected c3e()
	{
	}

	// Token: 0x0600973C RID: 38716
	public abstract string xq();

	// Token: 0x0600973D RID: 38717 RVA: 0x003B03A8 File Offset: 0x003AE5A8
	public override string ToString()
	{
		string text = this.xq();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return base.GetType().Name;
	}

	// Token: 0x0600973E RID: 38718
	public abstract c3e xs(int A_0);

	// Token: 0x0600973F RID: 38719
	public abstract c3e xr();

	// Token: 0x06009740 RID: 38720 RVA: 0x003B03D4 File Offset: 0x003AE5D4
	protected virtual void ael(c3e A_0)
	{
	}
}
