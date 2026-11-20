using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02001460 RID: 5216
[eiz("XRV")]
[Serializable]
public sealed class gu : evd, ISerializable
{
	// Token: 0x06007597 RID: 30103 RVA: 0x0031CEE4 File Offset: 0x0031B0E4
	private gu(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (bool?)A_0.GetValue("XRV:V", typeof(bool?));
		this.b = (Point)A_0.GetValue("XRV:IN", typeof(Point));
		di7.ReadEvent<EventArgs>("XRV:V1", ref this.c, A_0);
	}

	// Token: 0x06007598 RID: 30104 RVA: 0x0031CF48 File Offset: 0x0031B148
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XRV:V", this.a);
		info.AddValue("XRV:IN", this.b);
		di7.WriteEvent<EventArgs>("XRV:V1", this.c, info);
	}

	// Token: 0x06007599 RID: 30105 RVA: 0x0031CF88 File Offset: 0x0031B188
	public bool? gl()
	{
		return this.a;
	}

	// Token: 0x0600759A RID: 30106 RVA: 0x0031CF90 File Offset: 0x0031B190
	public gu()
	{
	}

	// Token: 0x0600759B RID: 30107 RVA: 0x0031CF9C File Offset: 0x0031B19C
	[CompilerGenerated]
	public void gm(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600759C RID: 30108 RVA: 0x0031CFD4 File Offset: 0x0031B1D4
	[CompilerGenerated]
	public void gn(EventHandler<EventArgs> A_0)
	{
		EventHandler<EventArgs> eventHandler = this.c;
		EventHandler<EventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs> value = (EventHandler<EventArgs>)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this.c, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600759D RID: 30109 RVA: 0x0031D00C File Offset: 0x0031B20C
	public void go(ad5 A_0)
	{
		czh.a(A_0, "spellInvocation");
		this.a = new bool?(A_0.e().yw());
		if (this.c != null)
		{
			this.c(this, new EventArgs());
		}
	}

	// Token: 0x0400301D RID: 12317
	private bool? a;

	// Token: 0x0400301E RID: 12318
	private Point b;

	// Token: 0x0400301F RID: 12319
	[CompilerGenerated]
	private EventHandler<EventArgs> c;
}
