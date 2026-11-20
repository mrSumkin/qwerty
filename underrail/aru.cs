using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Audio;
using Ouroboros.Common.Aspects;

// Token: 0x0200130B RID: 4875
[eiz("TASEA")]
[Serializable]
public class aru : Aspect<c5x>, bp1, d9i
{
	// Token: 0x06006D29 RID: 27945 RVA: 0x002DA054 File Offset: 0x002D8254
	protected aru(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			di7.ReadDictionary<string, app>("_AudioInstances", ref this.a, A_0);
			return;
		}
		di7.ReadDictionary<string, app>("TASEA:AI", ref this.a, A_0);
		if (ell.a() >= 369)
		{
			this.b = A_0.GetBoolean("TASEA:SN");
			return;
		}
		this.b = true;
	}

	// Token: 0x06006D2A RID: 27946 RVA: 0x002DA0D0 File Offset: 0x002D82D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteDictionary<string, app>("TASEA:AI", this.a, info);
		info.AddValue("TASEA:SN", this.b);
	}

	// Token: 0x06006D2B RID: 27947 RVA: 0x002DA0FC File Offset: 0x002D82FC
	public Dictionary<string, app> e()
	{
		return this.a;
	}

	// Token: 0x06006D2C RID: 27948 RVA: 0x002DA104 File Offset: 0x002D8304
	public void a(Dictionary<string, app> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006D2D RID: 27949 RVA: 0x002DA110 File Offset: 0x002D8310
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06006D2E RID: 27950 RVA: 0x002DA118 File Offset: 0x002D8318
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006D2F RID: 27951 RVA: 0x002DA124 File Offset: 0x002D8324
	public aru(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006D30 RID: 27952 RVA: 0x002DA144 File Offset: 0x002D8344
	public string a()
	{
		string text;
		do
		{
			text = Guid.NewGuid().ToString();
		}
		while (this.a.ContainsKey(text));
		return text;
	}

	// Token: 0x06006D31 RID: 27953 RVA: 0x002DA174 File Offset: 0x002D8374
	public ef4? a(string A_0)
	{
		return this.a(Guid.NewGuid().ToString(), A_0, 1f, c9z.a, false, false);
	}

	// Token: 0x06006D32 RID: 27954 RVA: 0x002DA1A4 File Offset: 0x002D83A4
	public ef4? a(string A_0, string A_1, float A_2 = 1f, c9z A_3 = c9z.a, bool A_4 = false, bool A_5 = false)
	{
		if (base.a8() == null || base.a8().Zone == null)
		{
			return null;
		}
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null)
		{
			app app;
			this.a.TryGetValue(A_0, out app);
			bool flag;
			if (app != null)
			{
				if (aru.a(app, addon))
				{
					flag = true;
					this.a.Remove(A_0);
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				app app2 = new app();
				app2.b(A_4);
				app2.a(A_5);
				app2.a(A_1);
				app2.a(A_3);
				app2.a(A_2);
				this.a[A_0] = app2;
				this.a(addon, app2);
				return app2.e();
			}
		}
		return null;
	}

	// Token: 0x06006D33 RID: 27955 RVA: 0x002DA28C File Offset: 0x002D848C
	public bool d(string A_0)
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null)
		{
			app app;
			this.a.TryGetValue(A_0, out app);
			if (app != null && app.e() != null)
			{
				app.a(true);
				return addon.apw(app.e().Value);
			}
		}
		return false;
	}

	// Token: 0x06006D34 RID: 27956 RVA: 0x002DA2F8 File Offset: 0x002D84F8
	public bool c(string A_0)
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null)
		{
			app app;
			this.a.TryGetValue(A_0, out app);
			if (app != null && app.e() != null)
			{
				app.a(false);
				return addon.apx(app.e().Value);
			}
		}
		return false;
	}

	// Token: 0x06006D35 RID: 27957 RVA: 0x002DA364 File Offset: 0x002D8564
	public bool a(string A_0, bool A_1 = false)
	{
		app app;
		this.a.TryGetValue(A_0, out app);
		if (app != null && app.e() != null)
		{
			this.a.Remove(A_0);
			if (base.a8() != null && base.a8().Zone != null)
			{
				ax1 addon = base.a8().Zone.GetAddon<ax1>();
				if (addon != null)
				{
					return addon.apv(app.e().Value, A_1);
				}
			}
		}
		return false;
	}

	// Token: 0x06006D36 RID: 27958 RVA: 0x002DA3F0 File Offset: 0x002D85F0
	public bool a(string A_0, float A_1)
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null)
		{
			app app;
			this.a.TryGetValue(A_0, out app);
			if (app != null && app.e() != null)
			{
				app.a(A_1);
				return addon.apy(app.e().Value, A_1);
			}
		}
		return false;
	}

	// Token: 0x06006D37 RID: 27959 RVA: 0x002DA45C File Offset: 0x002D865C
	public SoundState? b(string A_0)
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null)
		{
			app app;
			this.a.TryGetValue(A_0, out app);
			if (app != null && app.e() != null)
			{
				return addon.apz(app.e().Value);
			}
		}
		return null;
	}

	// Token: 0x06006D38 RID: 27960 RVA: 0x002DA4C8 File Offset: 0x002D86C8
	public void mx()
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null && this.a != null)
		{
			foreach (KeyValuePair<string, app> keyValuePair in this.a)
			{
				this.a(addon, keyValuePair.Value);
			}
		}
	}

	// Token: 0x06006D39 RID: 27961 RVA: 0x002DA54C File Offset: 0x002D874C
	public void my()
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		List<string> list = new List<string>();
		if (addon != null && this.a != null)
		{
			foreach (KeyValuePair<string, app> keyValuePair in this.a)
			{
				if (keyValuePair.Value.e() != null)
				{
					if (aru.a(keyValuePair.Value, addon))
					{
						list.Add(keyValuePair.Key);
					}
					else if (this.b || keyValuePair.Value.f())
					{
						addon.apv(keyValuePair.Value.e().Value, false);
					}
				}
			}
		}
		foreach (string key in list)
		{
			this.a.Remove(key);
		}
	}

	// Token: 0x06006D3A RID: 27962 RVA: 0x002DA68C File Offset: 0x002D888C
	public static aru a(c5x A_0)
	{
		aru aru = A_0.GetAspect<aru>();
		if (aru == null)
		{
			aru = new aru(A_0);
			A_0.SetAspect<aru>(aru);
		}
		return aru;
	}

	// Token: 0x06006D3B RID: 27963 RVA: 0x002DA6B8 File Offset: 0x002D88B8
	public bool b()
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		List<string> list = new List<string>();
		bool result;
		try
		{
			foreach (KeyValuePair<string, app> keyValuePair in this.a)
			{
				if (!keyValuePair.Value.f() && !keyValuePair.Value.c())
				{
					if (!aru.a(keyValuePair.Value, addon))
					{
						return true;
					}
					list.Add(keyValuePair.Key);
				}
			}
			result = false;
		}
		finally
		{
			if (list.Count > 0)
			{
				foreach (string key in list)
				{
					this.a.Remove(key);
				}
			}
		}
		return result;
	}

	// Token: 0x06006D3C RID: 27964 RVA: 0x002DA7E0 File Offset: 0x002D89E0
	public void pt(bool A_0)
	{
		ax1 addon = base.a8().Zone.GetAddon<ax1>();
		if (addon != null && this.a != null)
		{
			foreach (KeyValuePair<string, app> keyValuePair in this.a)
			{
				if (keyValuePair.Key.StartsWith("pow_") && keyValuePair.Value.e() != null)
				{
					SoundState? soundState = addon.apz(keyValuePair.Value.e().Value);
					if (A_0)
					{
						if (soundState == null || soundState.Value == SoundState.Paused)
						{
							addon.apx(keyValuePair.Value.e().Value);
						}
					}
					else
					{
						SoundState? soundState2 = soundState;
						SoundState soundState3 = SoundState.Playing;
						if (soundState2.GetValueOrDefault() == soundState3 & soundState2 != null)
						{
							addon.apw(keyValuePair.Value.e().Value);
						}
					}
				}
			}
		}
	}

	// Token: 0x06006D3D RID: 27965 RVA: 0x002DA91C File Offset: 0x002D8B1C
	private void a(ax1 A_0, app A_1)
	{
		float a_;
		if (A_1.c())
		{
			a_ = 0f;
		}
		else
		{
			a_ = A_1.b();
		}
		A_1.a(A_0.apu(base.a8(), A_1.a(), a_, A_1.f(), A_1.d()));
		if (A_1.e() != null && A_1.c())
		{
			A_0.apw(A_1.e().Value);
			A_0.apy(A_1.e().Value, A_1.b());
		}
	}

	// Token: 0x06006D3E RID: 27966 RVA: 0x002DA9BC File Offset: 0x002D8BBC
	private static bool a(app A_0, ax1 A_1)
	{
		ef4? ef = A_0.e();
		if (ef != null)
		{
			SoundState? soundState = A_1.apz(ef.Value);
			return soundState == null || soundState.Value == SoundState.Stopped;
		}
		return true;
	}

	// Token: 0x04002CB7 RID: 11447
	private Dictionary<string, app> a = new Dictionary<string, app>();

	// Token: 0x04002CB8 RID: 11448
	private bool b = true;
}
