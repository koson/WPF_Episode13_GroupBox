# สคริปต์การสอน: WPF Episode 13 - GroupBox

## เนื้อหาที่จะสอน

### 1. GroupBox คืออะไร
- Control สำหรับจัดกลุ่ม Controls ที่เกี่ยวข้องกัน
- มีกรอบและหัวข้อ (Header)
- ช่วยจัดระเบียบ UI

### 2. GroupBox Properties
- Header - หัวข้อกลุ่ม
- Content - Controls ภายใน
- BorderBrush, BorderThickness - กรอบ
- Background, Padding - พื้นหลังและระยะห่าง

### 3. การใช้งาน
- Form Sections (แบบฟอร์มแบ่งส่วน)
- Settings Panel (ตั้งค่าแบ่งกลุ่ม)
- Radio Button Groups
- Related Controls Grouping

---

## ส่วนที่ 1: Introduction (0:00 - 2:00)

**สวัสดีครับทุกคน**

ยินดีต้อนรับกลับมาสู่ WPF Tutorial Series ของเรา

วันนี้เราจะมาเรียนรู้เกี่ยวกับ **GroupBox** ซึ่งเป็น Control ที่ใช้บ่อยมาก!

GroupBox ทำอะไร?
- จัดกลุ่ม Controls ที่เกี่ยวข้องกัน
- มีกรอบและหัวข้อชัดเจน
- ช่วยจัดระเบียบ UI

**คิดเหมือนกับกล่องที่มีป้ายชื่อ!**

เหมาะมากสำหรับ Form, Settings, Options!

---

## ส่วนที่ 2: GroupBox พื้นฐาน (2:00 - 6:00)

### Demo 2.1: Basic GroupBox

```xml
<GroupBox Header="Personal Information">
    <StackPanel>
        <TextBlock Text="Name:"/>
        <TextBox Margin="0,5,0,10"/>
        
        <TextBlock Text="Email:"/>
        <TextBox Margin="0,5,0,10"/>
        
        <TextBlock Text="Phone:"/>
        <TextBox Margin="0,5"/>
    </StackPanel>
</GroupBox>
```

**อธิบาย:**
- `Header` - หัวข้อกลุ่ม "Personal Information"
- มีกรอบรอบๆ
- Controls ภายใน - TextBlock, TextBox
- ดูเป็นระเบียบชัดเจน

### Demo 2.2: กับ Border เปรียบเทียบ

**GroupBox:**
```xml
<GroupBox Header="Settings" Padding="10">
    <CheckBox Content="Enable notifications"/>
</GroupBox>
```

**Border:**
```xml
<Border BorderBrush="Gray" BorderThickness="1" Padding="10">
    <CheckBox Content="Enable notifications"/>
</Border>
```

**ความแตกต่าง:**
- GroupBox มี Header ในตัว
- Border ไม่มี Header
- GroupBox เหมาะสำหรับจัดกลุ่ม
- Border เหมาะสำหรับตกแต่ง

---

## ส่วนที่ 3: Header Customization (6:00 - 10:00)

### Demo 3.1: Simple Header

```xml
<GroupBox Header="📧 Contact Information" Padding="10">
    <StackPanel>
        <TextBlock Text="Email: john@example.com"/>
        <TextBlock Text="Phone: +1 234 567 8900"/>
    </StackPanel>
</GroupBox>
```

Header รองรับ Emoji!

### Demo 3.2: Custom Header

```xml
<GroupBox Padding="10">
    <GroupBox.Header>
        <StackPanel Orientation="Horizontal">
            <TextBlock Text="⚙️" FontSize="20" Margin="0,0,10,0"/>
            <TextBlock Text="Settings" 
                       FontSize="16" 
                       FontWeight="Bold" 
                       VerticalAlignment="Center"/>
        </StackPanel>
    </GroupBox.Header>
    
    <StackPanel>
        <CheckBox Content="Enable notifications"/>
        <CheckBox Content="Auto-save" IsChecked="True"/>
        <CheckBox Content="Dark mode"/>
    </StackPanel>
</GroupBox>
```

Header แบบ Rich Content!

### Demo 3.3: Colored Header

```xml
<GroupBox Padding="10">
    <GroupBox.Header>
        <Border Background="DodgerBlue" 
                CornerRadius="5" 
                Padding="10,5">
            <TextBlock Text="🚀 Premium Features" 
                       Foreground="White" 
                       FontWeight="Bold"/>
        </Border>
    </GroupBox.Header>
    
    <StackPanel>
        <CheckBox Content="✨ Advanced Analytics"/>
        <CheckBox Content="☁️ Cloud Storage (1TB)"/>
        <CheckBox Content="🔒 Enhanced Security"/>
    </StackPanel>
</GroupBox>
```

---

## ส่วนที่ 4: RadioButton Groups (10:00 - 14:00)

### Demo 4.1: RadioButton in GroupBox

```xml
<GroupBox Header="📧 Contact Method" Padding="10">
    <StackPanel>
        <RadioButton Content="Email" IsChecked="True" Margin="5"/>
        <RadioButton Content="Phone" Margin="5"/>
        <RadioButton Content="SMS" Margin="5"/>
    </StackPanel>
</GroupBox>
```

**ข้อดี:**
- ชัดเจนว่า RadioButton เหล่านี้เป็นกลุ่มเดียวกัน
- User เข้าใจง่ายว่าเลือกได้ 1 อัน

### Demo 4.2: Multiple RadioButton Groups

```xml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
    
    <GroupBox Grid.Column="0" 
              Header="📧 Contact Method" 
              Padding="10" 
              Margin="5">
        <StackPanel>
            <RadioButton Content="Email" IsChecked="True"/>
            <RadioButton Content="Phone"/>
            <RadioButton Content="SMS"/>
        </StackPanel>
    </GroupBox>
    
    <GroupBox Grid.Column="1" 
              Header="🎨 Theme" 
              Padding="10" 
              Margin="5">
        <StackPanel>
            <RadioButton Content="Light" IsChecked="True"/>
            <RadioButton Content="Dark"/>
            <RadioButton Content="Auto"/>
        </StackPanel>
    </GroupBox>
</Grid>
```

**สำคัญ:** แต่ละ GroupBox = กลุ่ม RadioButton แยกกัน!

### Demo 4.3: Payment Method

```xml
<GroupBox Header="💳 Payment Method" Padding="10">
    <StackPanel>
        <RadioButton Content="Credit Card" IsChecked="True" Margin="5"/>
        <RadioButton Content="PayPal" Margin="5"/>
        <RadioButton Content="Bank Transfer" Margin="5"/>
        <RadioButton Content="Cash on Delivery" Margin="5"/>
    </StackPanel>
</GroupBox>
```

---

## ส่วนที่ 5: Form Sections (14:00 - 20:00)

### Demo 5.1: Registration Form

```xml
<StackPanel Margin="20">
    <TextBlock Text="User Registration" 
               FontSize="24" 
               FontWeight="Bold" 
               Margin="0,0,0,20"/>
    
    <GroupBox Header="👤 Basic Information" Padding="10" Margin="0,5">
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/>
                <RowDefinition Height="Auto"/>
                <RowDefinition Height="Auto"/>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>
            
            <TextBlock Grid.Row="0" Grid.Column="0" 
                       Text="Username:" 
                       VerticalAlignment="Center" 
                       Margin="0,5,10,5"/>
            <TextBox Grid.Row="0" Grid.Column="1" 
                     Padding="5" 
                     Margin="0,5"/>
            
            <TextBlock Grid.Row="1" Grid.Column="0" 
                       Text="Email:" 
                       VerticalAlignment="Center" 
                       Margin="0,5,10,5"/>
            <TextBox Grid.Row="1" Grid.Column="1" 
                     Padding="5" 
                     Margin="0,5"/>
            
            <TextBlock Grid.Row="2" Grid.Column="0" 
                       Text="Password:" 
                       VerticalAlignment="Center" 
                       Margin="0,5,10,5"/>
            <PasswordBox Grid.Row="2" Grid.Column="1" 
                         Padding="5" 
                         Margin="0,5"/>
        </Grid>
    </GroupBox>
    
    <GroupBox Header="📍 Address" Padding="10" Margin="0,5">
        <StackPanel>
            <TextBlock Text="Street:"/>
            <TextBox Padding="5" Margin="0,5,0,10"/>
            
            <TextBlock Text="City:"/>
            <TextBox Padding="5" Margin="0,5,0,10"/>
            
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                
                <StackPanel Grid.Column="0" Margin="0,0,5,0">
                    <TextBlock Text="State:"/>
                    <ComboBox Padding="5" Margin="0,5"/>
                </StackPanel>
                
                <StackPanel Grid.Column="1" Margin="5,0,0,0">
                    <TextBlock Text="Zip Code:"/>
                    <TextBox Padding="5" Margin="0,5"/>
                </StackPanel>
            </Grid>
        </StackPanel>
    </GroupBox>
    
    <GroupBox Header="🔔 Preferences" Padding="10" Margin="0,5">
        <StackPanel>
            <CheckBox Content="Receive newsletter"/>
            <CheckBox Content="Receive promotions" Margin="0,5"/>
            <CheckBox Content="SMS notifications" Margin="0,5"/>
        </StackPanel>
    </GroupBox>
    
    <Button Content="Register" 
            Background="DodgerBlue" 
            Foreground="White" 
            Padding="20,10" 
            Margin="0,20" 
            HorizontalAlignment="Center"/>
</StackPanel>
```

**Form จัดระเบียบดีมาก!**

### Demo 5.2: Settings Panel

```xml
<StackPanel Margin="20">
    <TextBlock Text="⚙️ Application Settings" 
               FontSize="24" 
               FontWeight="Bold" 
               Margin="0,0,0,20"/>
    
    <GroupBox Header="General" Padding="10" Margin="0,5">
        <StackPanel>
            <CheckBox Content="Start on Windows startup"/>
            <CheckBox Content="Minimize to system tray" IsChecked="True" Margin="0,5"/>
            <CheckBox Content="Check for updates automatically" IsChecked="True" Margin="0,5"/>
        </StackPanel>
    </GroupBox>
    
    <GroupBox Header="Display" Padding="10" Margin="0,5">
        <StackPanel>
            <TextBlock Text="Theme:"/>
            <ComboBox Margin="0,5,0,10">
                <ComboBoxItem Content="Light" IsSelected="True"/>
                <ComboBoxItem Content="Dark"/>
                <ComboBoxItem Content="Auto"/>
            </ComboBox>
            
            <TextBlock Text="Font Size:"/>
            <StackPanel Orientation="Horizontal" Margin="0,5">
                <Slider Width="200" 
                        Minimum="10" 
                        Maximum="24" 
                        Value="14" 
                        VerticalAlignment="Center"/>
                <TextBlock Text="14pt" 
                           Margin="10,0" 
                           VerticalAlignment="Center"/>
            </StackPanel>
        </StackPanel>
    </GroupBox>
    
    <GroupBox Header="Privacy" Padding="10" Margin="0,5">
        <StackPanel>
            <CheckBox Content="Share usage data"/>
            <CheckBox Content="Allow crash reports" IsChecked="True" Margin="0,5"/>
            <CheckBox Content="Personalized ads" Margin="0,5"/>
        </StackPanel>
    </GroupBox>
    
    <GroupBox Header="Advanced" Padding="10" Margin="0,5">
        <StackPanel>
            <CheckBox Content="Developer mode"/>
            <CheckBox Content="Enable logging" Margin="0,5"/>
            <CheckBox Content="Performance monitoring" Margin="0,5"/>
        </StackPanel>
    </GroupBox>
</StackPanel>
```

---

## ส่วนที่ 6: Styling GroupBox (20:00 - 24:00)

### Demo 6.1: Styled GroupBox

```xml
<GroupBox Header="🎯 Premium Features" 
          Padding="15"
          BorderBrush="DodgerBlue"
          BorderThickness="2"
          Background="AliceBlue">
    <StackPanel>
        <CheckBox Content="✨ Advanced Analytics" FontWeight="SemiBold"/>
        <CheckBox Content="🚀 Priority Support" FontWeight="SemiBold" Margin="0,5"/>
        <CheckBox Content="☁️ Cloud Storage (1TB)" FontWeight="SemiBold" Margin="0,5"/>
        <CheckBox Content="🔒 Enhanced Security" FontWeight="SemiBold" Margin="0,5"/>
    </StackPanel>
</GroupBox>
```

### Demo 6.2: Colored Groups

```xml
<UniformGrid Columns="2">
    <!-- Success Group -->
    <GroupBox Header="✅ Available" 
              Margin="5"
              BorderBrush="#28A745"
              BorderThickness="2"
              Background="#D4EDDA">
        <StackPanel>
            <CheckBox Content="Feature A"/>
            <CheckBox Content="Feature B"/>
        </StackPanel>
    </GroupBox>
    
    <!-- Warning Group -->
    <GroupBox Header="⚠️ Beta" 
              Margin="5"
              BorderBrush="#FFC107"
              BorderThickness="2"
              Background="#FFF3CD">
        <StackPanel>
            <CheckBox Content="Feature C"/>
            <CheckBox Content="Feature D"/>
        </StackPanel>
    </GroupBox>
</UniformGrid>
```

### Demo 6.3: Card-style GroupBox

```xml
<GroupBox Padding="15" Margin="10">
    <GroupBox.Header>
        <Border Background="#3F51B5" 
                CornerRadius="5" 
                Padding="10,5">
            <TextBlock Text="💼 Professional Plan" 
                       Foreground="White" 
                       FontSize="16" 
                       FontWeight="Bold"/>
        </Border>
    </GroupBox.Header>
    
    <GroupBox.Effect>
        <DropShadowEffect Color="Gray" 
                          BlurRadius="10" 
                          ShadowDepth="5" 
                          Opacity="0.3"/>
    </GroupBox.Effect>
    
    <StackPanel>
        <TextBlock Text="$49.99/month" 
                   FontSize="32" 
                   FontWeight="Bold" 
                   Foreground="#3F51B5" 
                   Margin="0,10"/>
        
        <StackPanel Margin="0,10">
            <TextBlock Text="✓ Unlimited projects" Margin="0,3"/>
            <TextBlock Text="✓ 24/7 Support" Margin="0,3"/>
            <TextBlock Text="✓ Advanced features" Margin="0,3"/>
            <TextBlock Text="✓ Priority updates" Margin="0,3"/>
        </StackPanel>
        
        <Button Content="Subscribe Now" 
                Background="#3F51B5" 
                Foreground="White" 
                Padding="15,8" 
                Margin="0,10"/>
    </StackPanel>
</GroupBox>
```

---

## ส่วนที่ 7: Nested GroupBoxes (24:00 - 27:00)

### Demo 7.1: Simple Nesting

```xml
<GroupBox Header="👤 User Account" Padding="10">
    <StackPanel>
        <GroupBox Header="Basic Info" 
                  Padding="10" 
                  Margin="0,5"
                  Background="LightGray">
            <StackPanel>
                <TextBlock Text="Username:"/>
                <TextBox Margin="0,5"/>
                
                <TextBlock Text="Email:"/>
                <TextBox Margin="0,5"/>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Security" 
                  Padding="10" 
                  Margin="0,5"
                  Background="LightGray">
            <StackPanel>
                <TextBlock Text="Password:"/>
                <PasswordBox Margin="0,5"/>
                
                <CheckBox Content="Enable two-factor authentication"/>
            </StackPanel>
        </GroupBox>
    </StackPanel>
</GroupBox>
```

**ระวัง:** ไม่ควรซ้อนเกิน 2 ระดับ!

### Demo 7.2: Product Configuration

```xml
<GroupBox Header="🖥️ Computer Configuration" Padding="10">
    <StackPanel>
        <GroupBox Header="Hardware" Padding="10" Margin="0,5">
            <StackPanel>
                <TextBlock Text="Processor:"/>
                <ComboBox Margin="0,5,0,10">
                    <ComboBoxItem Content="Intel Core i5"/>
                    <ComboBoxItem Content="Intel Core i7" IsSelected="True"/>
                    <ComboBoxItem Content="Intel Core i9"/>
                </ComboBox>
                
                <TextBlock Text="RAM:"/>
                <ComboBox Margin="0,5">
                    <ComboBoxItem Content="8 GB"/>
                    <ComboBoxItem Content="16 GB" IsSelected="True"/>
                    <ComboBoxItem Content="32 GB"/>
                </ComboBox>
            </StackPanel>
        </GroupBox>
        
        <GroupBox Header="Software" Padding="10" Margin="0,5">
            <StackPanel>
                <CheckBox Content="Microsoft Office"/>
                <CheckBox Content="Adobe Creative Suite" IsChecked="True" Margin="0,5"/>
                <CheckBox Content="Antivirus Software" IsChecked="True" Margin="0,5"/>
            </StackPanel>
        </GroupBox>
    </StackPanel>
</GroupBox>
```

---

## ส่วนที่ 8: Tips & Best Practices (27:00 - 30:00)

### 8.1 ใช้ Header ที่ชัดเจน

```xml
<!-- ✅ ดี: Header ชัดเจน -->
<GroupBox Header="📧 Contact Information">
    <!-- Content -->
</GroupBox>

<!-- ⚠️ ไม่ดี: Header คลุมเครือ -->
<GroupBox Header="Info">
    <!-- Content -->
</GroupBox>
```

### 8.2 จัดกลุ่มที่เกี่ยวข้องกัน

```xml
<!-- ✅ ดี: จัดกลุ่มที่เกี่ยวข้อง -->
<GroupBox Header="Address">
    <StackPanel>
        <TextBox/>  <!-- Street -->
        <TextBox/>  <!-- City -->
        <TextBox/>  <!-- Zip -->
    </StackPanel>
</GroupBox>

<!-- ⚠️ ไม่ดี: ไม่เกี่ยวข้องกัน -->
<GroupBox Header="Mixed">
    <StackPanel>
        <TextBox/>  <!-- Email -->
        <ComboBox/> <!-- Theme -->
        <CheckBox/> <!-- Newsletter -->
    </StackPanel>
</GroupBox>
```

### 8.3 ใช้ Padding เหมาะสม

```xml
<!-- ✅ ดี: มี Padding -->
<GroupBox Header="Settings" Padding="10">
    <CheckBox Content="Enable"/>
</GroupBox>

<!-- ⚠️ ไม่ดี: ไม่มี Padding -->
<GroupBox Header="Settings">
    <CheckBox Content="Enable"/>  <!-- ติดกรอบ -->
</GroupBox>
```

### 8.4 ระวัง Nested ลึกเกินไป

```xml
<!-- ❌ หลีกเลี่ยง: ซ้อนเกิน 2 ระดับ -->
<GroupBox>
    <GroupBox>
        <GroupBox>
            <TextBlock Text="Too deep!"/>
        </GroupBox>
    </GroupBox>
</GroupBox>
```

---

## ส่วนที่ 9: Wrap Up และ Outro (30:00 - 32:00)

**สรุปสิ่งที่เราได้เรียนรู้วันนี้:**

1. ✅ GroupBox = จัดกลุ่ม Controls ที่เกี่ยวข้อง
2. ✅ Header - หัวข้อกลุ่ม (รองรับ Custom)
3. ✅ RadioButton Groups - แยกกลุ่มชัดเจน
4. ✅ Form Sections - จัดระเบียบ Form
5. ✅ Styling - ปรับแต่งสี กรอบ พื้นหลัง
6. ✅ Nested GroupBoxes - ซ้อนได้ (ไม่เกิน 2 ระดับ)

**GroupBox เหมาะสำหรับ:**
- Form Sections (แบ่งส่วนฟอร์ม)
- Settings Panel (ตั้งค่าแบ่งกลุ่ม)
- RadioButton Groups (กลุ่มตัวเลือก)
- Related Controls (Controls ที่เกี่ยวข้อง)
- Options Panel (ตัวเลือกต่างๆ)

**จุดเด่นของ GroupBox:**
- จัดระเบียบ UI
- ชัดเจน มีหัวข้อ
- แยกกลุ่มได้ดี
- ใช้ง่าย

**ในตอนต่อไป:**

เราจะมาเรียนรู้เกี่ยวกับ **TabControl** ซึ่งเป็น Control สำหรับ
สร้าง Multi-page Interface แบบ Tabbed เหมาะสำหรับแอพที่มีหลายหน้า!

**อย่าลืม:**
- กด Like ถ้าชอบ
- Subscribe เพื่อติดตามตอนต่อไป
- Comment บอกว่าอยากเรียนเรื่องอะไรต่อไป

**ขอบคุณที่รับชมครับ แล้วพบกันใหม่ตอนหน้า สวัสดีครับ!**

---

## เอกสารอ้างอิง

### Official Documentation
- [GroupBox Class - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.groupbox)
- [HeaderedContentControl Class - Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.headeredcontentcontrol)

### Properties Reference
```
Header: Object (หัวข้อ - รองรับ String, UIElement)
Content: Object (เนื้อหาภายใน)
BorderBrush: Brush (สีกรอบ)
BorderThickness: Thickness (ความหนากรอบ)
Background: Brush (พื้นหลัง)
Padding: Thickness (ระยะห่างภายใน)
```

---

## GroupBox vs Border vs Panel

| Feature | GroupBox | Border | Panel |
|---------|----------|--------|-------|
| **Header** | ✅ มี | ❌ ไม่มี | ❌ ไม่มี |
| **Border** | ✅ มี | ✅ มี | ❌ ไม่มี |
| **Purpose** | Grouping | Decoration | Layout |
| **Best For** | Related Controls | Visual Frame | Arranging |

---

## Tips & Best Practices

1. **Clear Headers**: ใช้ Header ที่บอกเนื้อหาชัดเจน
2. **Related Content**: จัดกลุ่มเฉพาะที่เกี่ยวข้องกัน
3. **Padding**: ใช้ Padding 10-15 px
4. **Avoid Deep Nesting**: ไม่ควรซ้อนเกิน 2 ระดับ
5. **Icons in Header**: ใช้ Icon เพิ่มความชัดเจน

---

## Common Mistakes (ข้อผิดพลาดที่พบบ่อย)

### ❌ Header ไม่ชัดเจน
```xml
<!-- ผิด: ไม่รู้ว่ากลุ่มอะไร -->
<GroupBox Header="Group 1">
    <!-- Content -->
</GroupBox>
```

### ✅ ถูกต้อง
```xml
<GroupBox Header="📧 Contact Information">
    <!-- Content -->
</GroupBox>
```

### ❌ จัดกลุ่มไม่เกี่ยวข้องกัน
```xml
<!-- ผิด: ไม่เกี่ยวข้อง -->
<GroupBox Header="Settings">
    <StackPanel>
        <TextBox/>      <!-- Email -->
        <CheckBox/>     <!-- Dark Mode -->
        <ComboBox/>     <!-- Country -->
    </StackPanel>
</GroupBox>
```

### ✅ ถูกต้อง
```xml
<!-- แยกกลุ่มที่เกี่ยวข้อง -->
<GroupBox Header="Account">
    <StackPanel>
        <TextBox/>      <!-- Email -->
        <TextBox/>      <!-- Password -->
    </StackPanel>
</GroupBox>
```

### ❌ ไม่มี Padding
```xml
<!-- ผิด: Content ติดกรอบ -->
<GroupBox Header="Info">
    <TextBlock Text="Content"/>
</GroupBox>
```

### ✅ ถูกต้อง
```xml
<GroupBox Header="Info" Padding="10">
    <TextBlock Text="Content"/>
</GroupBox>
```

---

## Code Examples Repository

Source code สำหรับ Episode นี้สามารถดาวน์โหลดได้ที่:
- GitHub: [WPF_Episode13_GroupBox](https://github.com/koson/WPF_Episode13_GroupBox)

---

**End of Script**