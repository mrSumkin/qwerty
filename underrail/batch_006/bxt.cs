using System;
using System.IO;
using SFML.Audio;

// Token: 0x02000073 RID: 115
public sealed class bxt
{
	// Token: 0x06000236 RID: 566 RVA: 0x0000B5DC File Offset: 0x000097DC
	public abr b()
	{
		return this.a;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000B5E4 File Offset: 0x000097E4
	public float a()
	{
		return this.c;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000B5EC File Offset: 0x000097EC
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000B5F8 File Offset: 0x000097F8
	internal bxt(abr A_0, float A_1)
	{
		this.c = A_1;
		this.a = A_0;
		this.a.b();
		string filename = Path.Combine(bpo.GetServiceOrThrow<d67>().lh().RootDirectory, A_0.d().b());
		this.b = new Music(filename);
		this.b.Loop = true;
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		this.a(serviceOrThrow as b6d);
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000B670 File Offset: 0x00009870
	public void a(b6d A_0)
	{
		if (this.b != null)
		{
			this.b.Volume = this.c * A_0.ads()[c9z.c] * this.a.d().a() * 100f;
			if (this.b.Status != SoundStatus.Playing)
			{
				this.b.Play();
			}
			if (A_0.adx() != null)
			{
				this.b.Pitch = A_0.adx().Value;
				return;
			}
			this.b.Pitch = 1f;
		}
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000B718 File Offset: 0x00009918
	public void c()
	{
		if (this.b != null)
		{
			if (this.b.Status != SoundStatus.Stopped)
			{
				this.b.Stop();
			}
			this.b.Dispose();
			this.b = null;
		}
	}

	// Token: 0x04000394 RID: 916
	private abr a;

	// Token: 0x04000395 RID: 917
	private Music b;

	// Token: 0x04000396 RID: 918
	private float c;
}
