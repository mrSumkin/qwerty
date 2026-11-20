using System;
using System.Runtime.Serialization;

// Token: 0x020006A9 RID: 1705
[eiz("RFBP")]
[Serializable]
public sealed class bf4 : ap
{
	// Token: 0x06002C26 RID: 11302 RVA: 0x000FD76C File Offset: 0x000FB96C
	private bf4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x000FD778 File Offset: 0x000FB978
	public bf4()
	{
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x000FD780 File Offset: 0x000FB980
	public override string ToString()
	{
		return string.Format("{0}: true or false", base.c());
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x000FD794 File Offset: 0x000FB994
	public override object j1(Random A_0)
	{
		return (A_0 ?? new Random()).NextDouble() < 0.5;
	}
}
