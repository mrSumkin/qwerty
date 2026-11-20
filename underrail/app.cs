using System;
using System.Runtime.Serialization;

// Token: 0x02001189 RID: 4489
[eiz("AI")]
[Serializable]
public sealed class app : ISerializable
{
	// Token: 0x06005FD0 RID: 24528 RVA: 0x0029BE98 File Offset: 0x0029A098
	private app(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("AI:SI");
			this.b = A_0.GetSingle("AI:V");
			this.c = A_0.GetBoolean("AI:IL");
			this.d = A_0.GetBoolean("AI:P");
			this.e = (c9z)A_0.GetValue("AI:ST", typeof(c9z));
			this.f = (ef4?)A_0.GetValue("AI:K", typeof(ef4?));
			return;
		}
		if (base.GetType() == typeof(app))
		{
			this.a = A_0.GetString("_SfxId");
			this.b = A_0.GetSingle("_Volume");
			this.c = A_0.GetBoolean("_IsLooped");
			this.d = A_0.GetBoolean("_Paused");
			this.e = (c9z)A_0.GetValue("_SoundType", typeof(c9z));
			this.f = (ef4?)A_0.GetValue("_Key", typeof(ef4?));
			return;
		}
		this.a = A_0.GetString("AudioInstance+_SfxId");
		this.b = A_0.GetSingle("AudioInstance+_Volume");
		this.c = A_0.GetBoolean("AudioInstance+_IsLooped");
		this.d = A_0.GetBoolean("AudioInstance+_Paused");
		this.e = (c9z)A_0.GetValue("AudioInstance+_SoundType", typeof(c9z));
		this.f = (ef4?)A_0.GetValue("AudioInstance+_Key", typeof(ef4?));
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x0029C068 File Offset: 0x0029A268
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AI:SI", this.a);
		info.AddValue("AI:V", this.b);
		info.AddValue("AI:IL", this.c);
		info.AddValue("AI:P", this.d);
		info.AddValue("AI:ST", this.e);
		info.AddValue("AI:K", this.f);
	}

	// Token: 0x06005FD2 RID: 24530 RVA: 0x0029C0E8 File Offset: 0x0029A2E8
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005FD3 RID: 24531 RVA: 0x0029C0F0 File Offset: 0x0029A2F0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x0029C0FC File Offset: 0x0029A2FC
	public ef4? e()
	{
		return this.f;
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x0029C104 File Offset: 0x0029A304
	public void a(ef4? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x0029C110 File Offset: 0x0029A310
	public float b()
	{
		return this.b;
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x0029C118 File Offset: 0x0029A318
	public void a(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x0029C124 File Offset: 0x0029A324
	public bool f()
	{
		return this.c;
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x0029C12C File Offset: 0x0029A32C
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x0029C138 File Offset: 0x0029A338
	public bool c()
	{
		return this.d;
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x0029C140 File Offset: 0x0029A340
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x0029C14C File Offset: 0x0029A34C
	public c9z d()
	{
		return this.e;
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x0029C154 File Offset: 0x0029A354
	public void a(c9z A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x0029C160 File Offset: 0x0029A360
	public app()
	{
	}

	// Token: 0x04002830 RID: 10288
	private string a;

	// Token: 0x04002831 RID: 10289
	private float b = 1f;

	// Token: 0x04002832 RID: 10290
	private bool c;

	// Token: 0x04002833 RID: 10291
	private bool d;

	// Token: 0x04002834 RID: 10292
	private c9z e;

	// Token: 0x04002835 RID: 10293
	private ef4? f;
}
