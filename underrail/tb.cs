using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common;
using Ouroboros.Core.Logging;

// Token: 0x02000069 RID: 105
public abstract class tb : Game, bef, d67, bbp
{
	// Token: 0x060001A8 RID: 424 RVA: 0x00009450 File Offset: 0x00007650
	protected ei2 f()
	{
		return this.a;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00009458 File Offset: 0x00007658
	public virtual Microsoft.Xna.Framework.Color atp()
	{
		return Microsoft.Xna.Framework.Color.White;
	}

	// Token: 0x060001AA RID: 426
	public abstract string atq();

	// Token: 0x060001AB RID: 427 RVA: 0x00009460 File Offset: 0x00007660
	[CompilerGenerated]
	public bool ku()
	{
		return this.aa;
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00009468 File Offset: 0x00007668
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00009474 File Offset: 0x00007674
	public tb(bool A_0 = false)
	{
		this.y = A_0;
		this.d = new GraphicsDeviceManager(this);
		this.d.PreferredBackBufferFormat = SurfaceFormat.Color;
		this.d.GraphicsProfile = GraphicsProfile.Reach;
		this.d.IsFullScreen = false;
		this.d.PreparingDeviceSettings += tb.a.a.a;
		base.IsMouseVisible = true;
		Form form = (Form)Control.FromHandle(base.Window.Handle);
		form.StartPosition = FormStartPosition.CenterScreen;
		form.FormBorderStyle = FormBorderStyle.None;
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00009534 File Offset: 0x00007734
	protected override void Initialize()
	{
		this.z = base.Window.Handle;
		bpo.RegisterService<bbp>(this);
		this.i = this.att();
		if (this.i == null)
		{
			this.i = d2a.a("masterconfig.xml");
		}
		this.i.e(AppDomain.CurrentDomain.BaseDirectory);
		if (!string.IsNullOrEmpty(this.i.h()))
		{
			base.Content = new ewl(base.Content.ServiceProvider, this.i.h());
		}
		else
		{
			base.Content = new ewl(base.Content.ServiceProvider, Path.Combine(this.i.i(), d7i.af));
		}
		bpo.RegisterService<d67>(this);
		this.o = new aa5(this.i.d());
		bpo.RegisterService<cvq>(this.o);
		cvq cvq = dr3.e();
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
		{
			string a_ = "ENTERING OUROBOROS. (Logger initialized)";
			cvq.n7(LogSeverity.Information, 100, a_);
		}
		this.p = new eni();
		bpo.RegisterService<e0r>(this.p);
		this.e = new SpriteBatch(base.GraphicsDevice);
		this.f = new cp9(base.GraphicsDevice, this.e, SpriteSortMode.Deferred, BlendState.AlphaBlend);
		try
		{
			this.j = base.Content.Load<Texture2D>("Concept\\LoadBar");
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
			{
				cvq.n7(LogSeverity.Error, 100, "Unable to load Ouroboros load bar.\nEX: " + ex.ToString());
			}
		}
		this.kv("Initializing assembly resolver");
		this.a = new af9();
		this.a.b(this.y);
		this.a.a(true);
		this.a.av1();
		this.b = new ResolveEventHandler(this.a.av0);
		this.c = new ResolveEventHandler(this.a);
		AppDomain.CurrentDomain.AssemblyResolve += this.b;
		AppDomain.CurrentDomain.TypeResolve += this.c;
		bpo.RegisterService<ei2>(this.a);
		this.kv("Creating data model element type map");
		this.a.d();
		dds.a = this.a;
		OuroborosDisplayMode ouroborosDisplayMode;
		int a_2;
		int num;
		bool a_3;
		this.atr(out ouroborosDisplayMode, out a_2, out num, out a_3);
		try
		{
			if (efl.SteamHelper_IsRunningOnWine())
			{
				this.a(true);
			}
		}
		catch
		{
		}
		try
		{
			if (efl.SteamHelper_IsOnSteamDeck())
			{
				ouroborosDisplayMode = OuroborosDisplayMode.BorderlessWindowed;
				a_2 = 1280;
				num = 800;
			}
		}
		catch
		{
		}
		this.k3(a_2, num);
		this.k6(ouroborosDisplayMode);
		this.k7(a_3);
		base.IsMouseVisible = (ouroborosDisplayMode == OuroborosDisplayMode.Windowed);
		this.k8();
		if (!string.IsNullOrEmpty(this.atq()))
		{
			this.k = base.Content.Load<SpriteFont>(this.ats(num));
		}
		this.h = pu.a;
		ThreadPool.QueueUserWorkItem(new WaitCallback(this.atu), new EventHandler(this.a));
	}

	// Token: 0x060001AF RID: 431
	protected abstract string ats(int A_0);

	// Token: 0x060001B0 RID: 432
	protected abstract void atr(out OuroborosDisplayMode A_0, out int A_1, out int A_2, out bool A_3);

	// Token: 0x060001B1 RID: 433 RVA: 0x00009898 File Offset: 0x00007A98
	protected override void Draw(GameTime gameTime)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		if (this.d.GraphicsDevice != null && this.d.GraphicsDevice.GraphicsDeviceStatus == GraphicsDeviceStatus.Normal)
		{
			RenderTarget2D renderTarget = null;
			bool flag = false;
			if (this.w && this.h == pu.b)
			{
				try
				{
					esj esj = new esj(this.d.GraphicsDevice.PresentationParameters.BackBufferWidth, this.d.GraphicsDevice.PresentationParameters.BackBufferHeight);
					bool flag2 = false;
					Viewport viewport = new Viewport(0, 0, esj.c, esj.d);
					float num = 1f;
					if (esj.c > 2048 || esj.d > 2048)
					{
						if (esj.c > esj.d)
						{
							num = 2048f / (float)esj.c;
						}
						else
						{
							num = 2048f / (float)esj.d;
						}
					}
					if (num != 1f)
					{
						esj.c = (int)((float)esj.c * num);
						esj.d = (int)((float)esj.d * num);
						flag2 = true;
					}
					renderTarget = new RenderTarget2D(this.d.GraphicsDevice, esj.c, esj.d, false, SurfaceFormat.Color, DepthFormat.None, 0, RenderTargetUsage.PreserveContents);
					this.d.GraphicsDevice.SetRenderTarget(renderTarget);
					if (flag2)
					{
						this.d.GraphicsDevice.Viewport = viewport;
					}
				}
				catch (Exception ex)
				{
					cvq cvq = dr3.e();
					if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 100))
					{
						cvq.n7(LogSeverity.Error, 104, "[Visual Controller] Error occurred while taking a screenshot. Exception: " + ex.ToString());
					}
				}
				flag = true;
				this.w = false;
				this.d.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
				this.f.a(null);
				MouseState state = Mouse.GetState();
				KeyboardState state2 = Keyboard.GetState();
				e6d a_ = new e6d(gameTime, state, state2);
				this.s.a(a_, this.f);
				this.f.a();
			}
			if (flag)
			{
				this.x = renderTarget;
				this.d.GraphicsDevice.SetRenderTarget(null);
			}
			this.d.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Black);
			this.f.a(null);
			if (this.h == pu.b)
			{
				MouseState state3 = Mouse.GetState();
				KeyboardState state4 = Keyboard.GetState();
				e6d a_2 = new e6d(gameTime, state3, state4);
				this.s.a(a_2, this.f);
			}
			else if (this.h == pu.a && this.j != null)
			{
				int preferredBackBufferWidth = this.d.PreferredBackBufferWidth;
				int preferredBackBufferHeight = this.d.PreferredBackBufferHeight;
				int num2;
				int num3;
				if (preferredBackBufferWidth / 2 > this.j.Width)
				{
					num2 = Convert.ToInt32(Math.Min(1200, preferredBackBufferWidth / 2));
					num3 = Convert.ToInt32((float)num2 / (float)this.j.Width * (float)(this.j.Height / 2));
				}
				else
				{
					num2 = this.j.Width;
					num3 = this.j.Height / 2;
				}
				Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle((preferredBackBufferWidth - num2) / 2, (preferredBackBufferHeight - num3) / 2, num2, num3);
				this.e.Draw(this.j, rectangle, new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, 0, this.j.Width, this.j.Height / 2)), Microsoft.Xna.Framework.Color.White);
				int num4 = (int)((double)this.j.Width * tb.n);
				int num5 = (int)((double)this.j.Width * this.l);
				int num6 = (int)((double)num2 * tb.n);
				int num7 = (int)((double)num2 * this.l);
				int num8 = Math.Min(num4, this.j.Width - num5);
				int width = Math.Min(num6, num2 - num7);
				if (num8 > 0)
				{
					Microsoft.Xna.Framework.Rectangle destinationRectangle = new Microsoft.Xna.Framework.Rectangle(rectangle.X + num7, rectangle.Y, width, num3);
					this.e.Draw(this.j, destinationRectangle, new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(num5, this.j.Height / 2, num8, this.j.Height / 2)), Microsoft.Xna.Framework.Color.White);
				}
				int num9 = num5 + num4 - this.j.Width;
				int width2 = num7 + num6 - num2;
				if (num9 > 0)
				{
					Microsoft.Xna.Framework.Rectangle destinationRectangle2 = new Microsoft.Xna.Framework.Rectangle(rectangle.X, rectangle.Y, width2, num3);
					this.e.Draw(this.j, destinationRectangle2, new Microsoft.Xna.Framework.Rectangle?(new Microsoft.Xna.Framework.Rectangle(0, this.j.Height / 2, num9, this.j.Height / 2)), Microsoft.Xna.Framework.Color.White);
				}
				if (this.k != null && !string.IsNullOrEmpty(this.m))
				{
					Vector2 vector = this.k.MeasureString(this.m);
					Vector2 position = new Vector2((float)Convert.ToInt32((float)rectangle.X + ((float)rectangle.Width - vector.X) / 2f), (float)Convert.ToInt32((float)rectangle.Y + ((float)rectangle.Height - vector.Y) / 2f));
					this.e.DrawString(this.k, this.m, position, this.atp());
				}
			}
			this.f.a();
			if (this.h == pu.b && this.q != null)
			{
				this.q.a(gameTime);
			}
		}
		stopwatch.Stop();
		a88.a = stopwatch.Elapsed.TotalMilliseconds;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00009E80 File Offset: 0x00008080
	protected override void Update(GameTime gameTime)
	{
		MouseState state = Mouse.GetState();
		KeyboardState state2 = Keyboard.GetState();
		e6d e6d = new e6d(gameTime, state, state2);
		e6d.d = (base.IsActive || this.ku());
		if (this.h == pu.b)
		{
			if (!this.v)
			{
				this.b();
			}
			this.r.a(e6d);
		}
		else if (this.h == pu.a)
		{
			this.l += gameTime.ElapsedGameTime.TotalMilliseconds / 2000.0;
			if (this.l >= 1.0)
			{
				this.l -= 1.0;
			}
		}
		if (this.u != null)
		{
			this.u.b(e6d);
		}
		this.o.b();
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00009F6C File Offset: 0x0000816C
	protected override void OnExiting(object sender, EventArgs args)
	{
		cvq cvq = dr3.e();
		base.OnExiting(sender, args);
		this.t.d();
		this.q.b();
		AppDomain.CurrentDomain.AssemblyResolve -= this.b;
		AppDomain.CurrentDomain.TypeResolve -= this.c;
		if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 100))
		{
			string a_ = "EXITING OUROBOROS.";
			cvq.n7(LogSeverity.Information, 100, a_);
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00009FEC File Offset: 0x000081EC
	protected virtual d2a att()
	{
		return null;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00009FF0 File Offset: 0x000081F0
	protected virtual void atu(object A_0)
	{
		bpo.RegisterService<bef>(this);
		this.kv("Initializing dynamic resource manager");
		this.q = new a4q(base.Content);
		bpo.RegisterService<cne>(this.q);
		this.f.a = this.q;
		this.kv("Initializing logic manager");
		this.r = new bds();
		bpo.RegisterService<a1y>(this.r);
		this.kv("Initializing rendering manager");
		this.s = new ye();
		bpo.RegisterService<s6>(this.s);
		this.kv("Initializing modularity manager");
		this.t = new ah4();
		this.t.a(this.i.a(), this.i.b(), this.i.g());
		this.kv("Initializing workflow manager");
		this.u = new e1s();
		bpo.RegisterService<d4m>(this.u);
		EventHandler eventHandler = A_0 as EventHandler;
		if (eventHandler != null)
		{
			eventHandler(this, null);
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0000A0F8 File Offset: 0x000082F8
	private Assembly a(object A_0, ResolveEventArgs A_1)
	{
		if (A_1.Name != null)
		{
			string text = this.a.b(A_1.Name);
			if (text != null)
			{
				Type type = this.a.av3(text, "X", true);
				if (type != null)
				{
					return type.Assembly;
				}
			}
		}
		return null;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0000A150 File Offset: 0x00008350
	private void a(object A_0, EventArgs A_1)
	{
		this.h = pu.b;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0000A15C File Offset: 0x0000835C
	private void b()
	{
		base.IsMouseVisible = false;
		this.v = true;
		if (this.j != null)
		{
			this.j.Dispose();
		}
		this.a();
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0000A188 File Offset: 0x00008388
	private void a()
	{
		if (this.i.e() != null)
		{
			Type type = this.i.e().a();
			if (type != null)
			{
				try
				{
					btm btm = Activator.CreateInstance(type) as btm;
					if (btm == null)
					{
						throw new InvalidCastException(string.Format("Program initialization workflow was of type '{0}' which does not derive from '{1}'.", btm.GetType().FullName, typeof(btm).FullName));
					}
					this.u.avp(btm);
					return;
				}
				catch (Exception ex)
				{
					if (this.o != null && this.o.n8() && this.o.n9(LogSeverity.Error, 100))
					{
						string a_ = string.Format("Error occurred while creating an instance of program initialization workflow ('{0}'). It will not be executed. Exception: {1}", type.ToString(), ex.ToString());
						this.o.n7(LogSeverity.Error, 100, a_);
					}
					return;
				}
			}
			if (this.o != null && this.o.n8() && this.o.n9(LogSeverity.Error, 100))
			{
				string a_2 = "Failed to retrieve the program initialization workflow. It will not be executed.";
				this.o.n7(LogSeverity.Error, 100, a_2);
			}
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0000A2C0 File Offset: 0x000084C0
	public void kv(string A_0)
	{
		this.m = "Загрузка";
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0000A2D0 File Offset: 0x000084D0
	public void kw(string A_0)
	{
		tb.c c = new tb.c();
		c.a = A_0;
		Thread thread = new Thread(new ParameterizedThreadStart(c.a));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0000A300 File Offset: 0x00008500
	public string kx()
	{
		tb.b b = new tb.b();
		b.a = null;
		Thread thread = new Thread(new ParameterizedThreadStart(b.a));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
		return b.a;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0000A338 File Offset: 0x00008538
	[CompilerGenerated]
	public void ky(EventHandler A_0)
	{
		EventHandler eventHandler = this.ab;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0000A370 File Offset: 0x00008570
	[CompilerGenerated]
	public void kz(EventHandler A_0)
	{
		EventHandler eventHandler = this.ab;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.ab, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0000A3A8 File Offset: 0x000085A8
	public esj k0()
	{
		return new esj(base.GraphicsDevice.PresentationParameters.BackBufferWidth, this.d.GraphicsDevice.PresentationParameters.BackBufferHeight);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0000A3E0 File Offset: 0x000085E0
	public SurfaceFormat k1()
	{
		return base.GraphicsDevice.DisplayMode.Format;
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0000A3F4 File Offset: 0x000085F4
	public bool k2()
	{
		return base.GraphicsDevice.PresentationParameters.IsFullScreen;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000A408 File Offset: 0x00008608
	public void k3(int A_0, int A_1)
	{
		cvq cvq = dr3.e();
		try
		{
			this.d.PreferredBackBufferWidth = A_0;
			this.d.PreferredBackBufferHeight = A_1;
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 104))
			{
				cvq.n7(LogSeverity.Error, 104, "[Visual Controller] Error occurred while setting display resolution. Exception: " + ex.ToString());
			}
		}
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000A488 File Offset: 0x00008688
	public esj k4()
	{
		return new esj(this.d.PreferredBackBufferWidth, this.d.PreferredBackBufferHeight);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000A4A8 File Offset: 0x000086A8
	public void k5(SurfaceFormat A_0)
	{
		cvq cvq = dr3.e();
		try
		{
			this.d.PreferredBackBufferFormat = A_0;
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 104))
			{
				cvq.n7(LogSeverity.Error, 104, "[Visual Controller] Error occurred while setting display format. Exception: " + ex.ToString());
			}
		}
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0000A51C File Offset: 0x0000871C
	public void k6(OuroborosDisplayMode A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000A528 File Offset: 0x00008728
	public void k7(bool A_0)
	{
		this.d.SynchronizeWithVerticalRetrace = A_0;
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000A538 File Offset: 0x00008738
	public void k8()
	{
		cvq cvq = dr3.e();
		try
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Information, 104))
			{
				cvq.n7(LogSeverity.Information, 104, "[Visual Controller] Applying new display settings: " + this.d.ToString());
			}
			if (this.g == OuroborosDisplayMode.Windowed)
			{
				this.d.IsFullScreen = false;
				Form form = (Form)Control.FromHandle(base.Window.Handle);
				if (form.FormBorderStyle != FormBorderStyle.Fixed3D)
				{
					form.FormBorderStyle = FormBorderStyle.Fixed3D;
				}
				this.d.ApplyChanges();
			}
			else if (this.g == OuroborosDisplayMode.BorderlessWindowed)
			{
				this.d.IsFullScreen = false;
				Form form2 = (Form)Control.FromHandle(base.Window.Handle);
				System.Drawing.Rectangle bounds = Screen.FromPoint(form2.Location).Bounds;
				form2.StartPosition = FormStartPosition.Manual;
				if (form2.FormBorderStyle != FormBorderStyle.None)
				{
					form2.FormBorderStyle = FormBorderStyle.None;
				}
				this.d.ApplyChanges();
				form2.Location = new System.Drawing.Point(bounds.X, bounds.Y);
			}
			else
			{
				this.d.IsFullScreen = true;
				this.d.ApplyChanges();
			}
			if (this.ab != null)
			{
				this.ab(this, null);
			}
		}
		catch (Exception ex)
		{
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 104))
			{
				cvq.n7(LogSeverity.Error, 104, "[Visual Controller] Error occurred while applying new display settings. Exception: " + ex.ToString());
			}
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000A6EC File Offset: 0x000088EC
	public GraphicsDevice k9()
	{
		return base.GraphicsDevice;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000A6F4 File Offset: 0x000088F4
	public esj la()
	{
		Form form = (Form)Control.FromHandle(base.Window.Handle);
		return new esj(form.Width, form.Height);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000A728 File Offset: 0x00008928
	public Texture2D lb()
	{
		Texture2D texture2D = new Texture2D(base.GraphicsDevice, base.GraphicsDevice.PresentationParameters.BackBufferWidth, base.GraphicsDevice.PresentationParameters.BackBufferHeight, false, SurfaceFormat.Color);
		Microsoft.Xna.Framework.Rectangle value = new Microsoft.Xna.Framework.Rectangle(0, 0, texture2D.Width, texture2D.Height);
		int num = texture2D.Width * texture2D.Height;
		Microsoft.Xna.Framework.Color[] data = new Microsoft.Xna.Framework.Color[num];
		base.GraphicsDevice.GetBackBufferData<Microsoft.Xna.Framework.Color>(new Microsoft.Xna.Framework.Rectangle?(value), data, 0, num);
		texture2D.SetData<Microsoft.Xna.Framework.Color>(data);
		return texture2D;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000A7AC File Offset: 0x000089AC
	public void lc()
	{
		this.w = true;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000A7B8 File Offset: 0x000089B8
	public Texture2D ld()
	{
		Texture2D result = this.x;
		this.x = null;
		return result;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000A7C8 File Offset: 0x000089C8
	public string le()
	{
		return this.i.i();
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000A7D8 File Offset: 0x000089D8
	public string lf()
	{
		return base.Content.RootDirectory;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000A7E8 File Offset: 0x000089E8
	public IntPtr lg()
	{
		return this.z;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000A7F0 File Offset: 0x000089F0
	public ContentManager lh()
	{
		return base.Content;
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000A808 File Offset: 0x00008A08
	TimeSpan d67.d()
	{
		return base.TargetElapsedTime;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000A810 File Offset: 0x00008A10
	void bbp.e()
	{
		base.Exit();
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000A818 File Offset: 0x00008A18
	bool bbp.c()
	{
		return base.IsActive;
	}

	// Token: 0x0400034F RID: 847
	private af9 a;

	// Token: 0x04000350 RID: 848
	private ResolveEventHandler b;

	// Token: 0x04000351 RID: 849
	private ResolveEventHandler c;

	// Token: 0x04000352 RID: 850
	private GraphicsDeviceManager d;

	// Token: 0x04000353 RID: 851
	private SpriteBatch e;

	// Token: 0x04000354 RID: 852
	private cp9 f;

	// Token: 0x04000355 RID: 853
	private OuroborosDisplayMode g;

	// Token: 0x04000356 RID: 854
	private pu h;

	// Token: 0x04000357 RID: 855
	private d2a i;

	// Token: 0x04000358 RID: 856
	private Texture2D j;

	// Token: 0x04000359 RID: 857
	private SpriteFont k;

	// Token: 0x0400035A RID: 858
	private double l = 0.5 - tb.n / 2.0;

	// Token: 0x0400035B RID: 859
	private string m;

	// Token: 0x0400035C RID: 860
	private static readonly double n = 0.2;

	// Token: 0x0400035D RID: 861
	private aa5 o;

	// Token: 0x0400035E RID: 862
	private eni p;

	// Token: 0x0400035F RID: 863
	private a4q q;

	// Token: 0x04000360 RID: 864
	private bds r;

	// Token: 0x04000361 RID: 865
	private ye s;

	// Token: 0x04000362 RID: 866
	private ah4 t;

	// Token: 0x04000363 RID: 867
	private e1s u;

	// Token: 0x04000364 RID: 868
	private bool v;

	// Token: 0x04000365 RID: 869
	private bool w;

	// Token: 0x04000366 RID: 870
	private Texture2D x;

	// Token: 0x04000367 RID: 871
	private bool y;

	// Token: 0x04000368 RID: 872
	private IntPtr z;

	// Token: 0x04000369 RID: 873
	[CompilerGenerated]
	private bool aa;

	// Token: 0x0400036A RID: 874
	[CompilerGenerated]
	private EventHandler ab;

	// Token: 0x02000124 RID: 292
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		internal void a(object A_0, PreparingDeviceSettingsEventArgs A_1)
		{
			A_1.GraphicsDeviceInformation.PresentationParameters.RenderTargetUsage = RenderTargetUsage.PreserveContents;
		}

		// Token: 0x0400053B RID: 1339
		public static readonly tb.a a = new tb.a();

		// Token: 0x0400053C RID: 1340
		public static EventHandler<PreparingDeviceSettingsEventArgs> b;
	}

	// Token: 0x02000125 RID: 293
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x0001CABC File Offset: 0x0001ACBC
		internal void a(object A_0)
		{
			Clipboard.SetText(this.a);
		}

		// Token: 0x0400053D RID: 1341
		public string a;
	}

	// Token: 0x02000126 RID: 294
	[CompilerGenerated]
	private sealed class b
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		internal void a(object A_0)
		{
			this.a = Clipboard.GetText();
		}

		// Token: 0x0400053E RID: 1342
		public string a;
	}
}
